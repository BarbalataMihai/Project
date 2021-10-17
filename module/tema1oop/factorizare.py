from collections import defaultdict
from math import sqrt
#every time he enters in for
#will create for that number an element 0
#which will never be incremented
def delete_empty(prime):
    for number in list(prime.keys()):
        if prime[number] == 0:
            del prime[number]

def print_prime_factorization(prime):
    for number in prime:
        print ("Prime factor",number, "^",prime[number])
    print()


def prime_factors(n):
    prime = defaultdict(int)

    prime[2] = 0
    #while my number is even, increment the counter for number 2
    while n % 2 == 0:
        prime[2] += 1
        n /= 2
    
    for i in range(3,int(sqrt(n))+1,2):
        prime[i] = 0
        #while my number is divisible with i increment the element
        while n % i== 0:
            prime[i] += 1
            n /= i

    n = int(n)
    prime[n] = 0
    #if there are no other divisors
    #the number is prime
    if n > 2:
        prime[n] += 1

    delete_empty(prime)

    print_prime_factorization(prime)