class Solution:
    def generateMatrix(self, n: int) -> List[List[int]]:
        spirals = n/2 + 1
        grid = [[0 for col in range(n)] for row in range(n)]
        start_number = 1
        spiral = 0
        while spiral < spirals:     
            grid, start_number = self.oneSpiral(grid, n, start_number, spiral)
            spiral += 1
        return grid

    
    def oneSpiral(self, grid, n, start_number, spiral):
        i, j = spiral, spiral
        # upper row
        while j < (n-spiral):
            grid[i][j] = start_number
            start_number += 1
            j += 1
        j -= 1
        # righter column
        while i < (n-spiral-1):
            i += 1
            grid[i][j] = start_number
            start_number += 1
        # bottom row
        while j > spiral:
            j -= 1
            grid[i][j] = start_number
            start_number += 1
        # lefter column
        while i > spiral+1:
            i -= 1
            grid[i][j] = start_number
            start_number += 1
        
        return grid, start_number
            