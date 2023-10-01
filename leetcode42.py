def trap(height) -> int:
    left_edge = height[0]
    right_edge = height[-1]
    kusetus = False
    if max(height) == right_edge:
        kusetus = True
    if min(height) == max(height):
        return 0

    total_water = 0
    water_spots = height[1:-1]
    highest_left = 0
    highest_right = 0
    wall_height = 0
    for index, number in enumerate(water_spots):
        # find highest leftside
        highest_left = max(height[0:index + 1])
        # find highest rightside
        if kusetus:
            highest_right = right_edge
        else:
            highest_right = max(height[index + 2:])
        # "lowest" wall available
        wall_height = min(highest_left, highest_right)
        # water amount
        total_water += max(0, wall_height - number)
    return total_water


if __name__ == '__main__':
    height = [0,1,0,2,1,0,1,3,2,1,2,1]
    print(trap(height))


