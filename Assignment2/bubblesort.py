import time

def bubblesort(arr):
    n = len(arr)
    for i in range(n - 1):
        for j in range(n - i - 1):
            if arr[j] > arr[j + 1]:
                arr[j] = arr[j+ 1]
                arr[j+ 1] = arr[j]



arr = [1, 3, 2, 4, 6, 3, 3,2,35, 3, 64, 3,57, 4,3 , 5,45 ,7, 43,57,5 ,2]

start_time = time.time()

bubblesort(arr)

end_time = time.time()
elapsed_time = end_time - start_time

print(arr)
print("Time taken to sort the array: {:.5f} seconds".format(elapsed_time))