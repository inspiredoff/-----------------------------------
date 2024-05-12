from random import randint as rnd
import random
size = int(input('введите размер массива'))

array = [''.join([chr(rnd(32, 126)) for _ in range(rnd(1, 15))]) for _ in range(size)]
result_array= [i for i in array if len(i)<4]

print("входной массив-", array)
print("полученный массив-", result_array)
