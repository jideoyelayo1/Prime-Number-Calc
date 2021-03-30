def primeNums(n):
    nums = list(range(1,n))
    ans = []
    prime = 0
    while(len(nums) > 1):
        if nums[1] == 1:
            nums.pop(0)
        i = 0
        prime = nums[1]
        ans.append(nums[1])
        while i < len(nums):
            if nums[i]%prime == 0:
                nums.pop(i)
            i+=1
    return ans


n = int(input("Enter n: "))
print(primeNums(n))
print("The number of prime numbers are: "+ str(len(primeNums(n))))
