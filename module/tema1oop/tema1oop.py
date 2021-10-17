from factorizare import prime_factors
from partition import printAllUniqueParts
from square import square_root
from palindrome import det_palindrome
n = int(input("n= "))

printAllUniqueParts(n)

prime_factors(n)

m = square_root(n)

print (" the integer square root of",n,"=",m)
print()

det_palindrome(n)
print("\nthe given number is",n)
