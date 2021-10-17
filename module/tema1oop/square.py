 # Base cases 
def square_root(n):
    if n == 0 or n == 1:
        return n
    # Staring from 1, try all numbers until 
    # i*i is greater than or equal to n
    i = 1
    result = 1
    while result <= n:
        i += 1
        result = i * i

    return i - 1