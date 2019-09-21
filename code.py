import math
from skimage import io, color
import numpy as np
import copy


def openFileAndChangeLAB(filename):
    img = io.imread(filename)
    lab_img = color.rgb2lab(img)
    return lab_img


class Cluster:
    def __init__(self, x, y, l, a, b, num):
        self.x = x
        self.y = y
        self.l = l
        self.a = a
        self.b = b
        self.num = num
        self.point = []

    def update(self, x, y, l, a, b):
        self.x = x
        self.y = y
        self.l = l
        self.a = a
        self.b = b
        return self


class SLIC:
    def __init__(self, filename, K, M):
        self.K = K
        self.M = M
        self.img = openFileAndChangeLAB(filename)
        self.height = self.img.shape[0]
        self.width = self.img.shape[1]
        self.N = self.height * self.width
        self.S = math.sqrt(self.N / self.K)

        self.dis = np.full((self.height, self.width), np.inf)
        self.label = {}
        self.clusters = []


def initCluster(slic):
    i = 0
    j = 0
    num = 1
    while i < slic.height:
        while j < slic.width:
            center = Cluster(i, j, slic.img[i][j][0], slic.img[i][j][1], slic.img[i][j][2], num)
            num += 1
            slic.clusters.append(center)
            j += int(slic.S)
        i += int(slic.S)
        j = 0
    return slic


def getGradient(slic, x, y):
    if x + 1 >= slic.width:
        x = int(slic.width - 2)
    if y + 1 >= slic.height:
        y = int(slic.height - 2)

    gradient = slic.img[int(x + 1)][int(y + 1)][0] - slic.img[int(x)][int(y)][0] + \
               slic.img[int(x + 1)][int(y + 1)][1] - slic.img[int(x)][int(y)][1] + \
               slic.img[int(x + 1)][int(y + 1)][2] - slic.img[int(x)][int(y)][2]
    return gradient


def moveCluster(slic):
    print(len(slic.clusters))
    for i in range(len(slic.clusters)):
        slic.clusters[i]
        # for center in slic.clusters:
        init_gradient = getGradient(slic, slic.clusters[i].x, slic.clusters[i].y)
        new_center = Cluster(-1, -1, -1, -1, -1, slic.clusters[i].num)
        for dx in range(-1, 2):
            for dy in range(-1, 2):
                now_x = slic.clusters[i].x + dx
                now_y = slic.clusters[i].y + dy
                if now_x < 0 or now_x >= slic.height or now_y < 0 or now_y >= slic.width:
                    continue
                gradient = getGradient(slic, now_x, now_y)
                if gradient < init_gradient:
                    # print("change")
                    new_center = Cluster(now_x, now_y, slic.img[now_x][now_y][0], slic.img[now_x][now_y][1],
                                         slic.img[now_x][now_y][2], slic.clusters[i].num)
                    init_gradient = gradient
        if (slic.clusters[i].x != slic.clusters[i].x or slic.clusters[i].y != new_center.y) and new_center.x != -1 and new_center.y != -1:
            # print("change:", slic.clusters[i].x, slic.clusters[i].y, new_center.x, new_center.y)
            slic.clusters[i] = new_center
    return slic


def getDistane(slic, x1, y1, x2, y2):
    point1 = slic.img[x1][y1]
    point2 = slic.img[x2][y2]
    dc = math.sqrt(math.pow(point1[0] - point2[0], 2) + math.pow(point1[1] - point2[1], 2) +
                   math.pow(point1[2] - point2[2], 2))
    ds = math.sqrt(math.pow(x1 - x2, 2) + math.pow(y1 - y2, 2))
    d = math.sqrt(math.pow(dc / slic.M, 2) + math.pow(ds / slic.S, 2))
    return d


def labelAssign(slic):
    for i in range(len(slic.clusters)):
        #   slic.clusters[i]
        # for center in slic.clusters:
        for h in range(int(-2 * slic.S), int(2 * slic.S)):
            for w in range(int(-2 * slic.S), int(2 * slic.S)):
                now_x = int(slic.clusters[i].x + h)
                now_y = int(slic.clusters[i].y + w)
                if now_x < 0 or now_x >= slic.height or now_y < 0 or now_y >= slic.width:
                    continue
                dis = getDistane(slic, slic.clusters[i].x, slic.clusters[i].y, now_x, now_y)
                if dis < slic.dis[now_x][now_y]:
                    if (now_x, now_y) not in slic.label:
                        slic.label[(now_x, now_y)] = slic.clusters[i]
                        slic.clusters[i].point.append((now_x, now_y))
                    else:
                        old_center = slic.label[(now_x, now_y)]
                        # print(len(old_center.point))
                        # print(type(old_center.point))
                        old_center.point.remove((now_x, now_y))
                        slic.label[(now_x, now_y)] = slic.clusters[i]
                        slic.clusters[i].point.append((now_x, now_y))
                    slic.dis[now_x][now_y] = dis
    return slic


def updateCluster(slic):
    # 将每个聚类的中心的向量，更新成所有点的平均向量
    for i in range(len(slic.clusters)):
        #    slic.clusters[i]
        # for center in slic.clusters:
        new_l = 0
        new_a = 0
        new_b = 0
        new_x = 0
        new_y = 0
        cnt = 0
        for item in slic.clusters[i].point:
            new_l += slic.img[item[0]][item[1]][0]
            new_a += slic.img[item[0]][item[1]][1]
            new_b += slic.img[item[0]][item[1]][2]
            new_x += item[0]
            new_y += item[1]
            cnt += 1
        if cnt == 0:
            #print("hhhhh")
            continue
        new_l /= cnt
        new_a /= cnt
        new_b /= cnt
        new_x = int(new_x / cnt)
        new_y = int(new_y / cnt)
        slic.clusters[i].update(new_x, new_y, new_l, new_a, new_b)
    return slic


def saveImage(slic, path):
    new_img = np.copy(slic.img)
    for center in slic.clusters:
        for p in center.point:
            new_img[p[0]][p[1]][0] = center.l
            new_img[p[0]][p[1]][1] = center.a
            new_img[p[0]][p[1]][2] = center.b
        new_img[center.x][center.y][0] = 0
        new_img[center.x][center.y][1] = 0
        new_img[center.x][center.y][2] = 0
    rgb_arr = color.lab2rgb(new_img)
    io.imsave(path, rgb_arr)


def getE(slic_old, slic_new):
    xx = 0
    yy = 0
    for i in range(len(slic_old.clusters)):
        center1 = slic_old.clusters[i]
        center2 = slic_new.clusters[i]
        xx += math.pow(center1.x - center2.x, 2)
        yy += math.pow(center1.y - center2.y, 2)
    return math.sqrt(xx + yy)


def slicProcessing(slic):
    for i in range(10):
        slic_old = copy.deepcopy(slic)
        slic = labelAssign(slic)
        slic = updateCluster(slic)
        e = getE(slic_old, slic)
        print("iter " + str(i) + " error:", e)
        saveImage(slic, 'image' + str(i) + ".png")
        if e <= 1:
            break


if __name__ == '__main__':
    slic = SLIC("lenna.jpg", 500, 5) 
    slic = initCluster(slic)
    slic = moveCluster(slic)
    slicProcessing(slic)
