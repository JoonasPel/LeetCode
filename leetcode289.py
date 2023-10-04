class Solution:
    def gameOfLife(self, board: List[List[int]]) -> None:
        """
        Do not return anything, modify board in-place instead.
        """
        m = len(board)
        n = len(board[0])          
        board_copy = copy.deepcopy(board)

        for i, row in enumerate(board_copy):
            for j, value in enumerate(row):
                live_neighs = self.liveNeighbourCount(board_copy, i, j, m, n)
                live = value
                # condition 1 or 3
                if value == 1 and (live_neighs < 2 or live_neighs > 3):
                    live = 0      
                # condition 4
                elif value == 0 and live_neighs == 3:
                    live = 1
                board[i][j] = live
      
        
    def liveNeighbourCount(self, board, i, j, m, n):
        rows = [-1, 0, 1]
        columns = [-1, 0, 1]
        count = 0
        for row in rows:
            for column in columns:
                x = i + row
                y = j + column
                if (x > -1 and x < m ) and (y > -1 and y < n):
                    count += board[x][y]    
        return count - board[i][j]
            