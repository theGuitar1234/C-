class Solution(object):
    def twoSum(self, nums, target):
        for i in nums :
            for j in range(nums.index(i)+1, len(nums)) :
                if i+nums[j] == target :
                    z = [nums.index(i), j]
                    return z

solution = Solution()
print(solution.twoSum([2,7], 9))
        