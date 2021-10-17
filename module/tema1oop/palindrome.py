
# Utility function to  
# reverse the number n 
def palindrome(n):
    temp = n
    rev = 0
    j = 0
    while(n > 0):
        digit = n % 10
        rev = rev * 10 + digit
        n = n // 10
        #check if a number is palindrome  
        #returns it if it is
        #if it is not, it becomes 1
    if(temp == rev):
        j = 1
    return j

def det_palindrome(n):
    count = 0
    total = 1
    while(count < n):
        if(palindrome(total)):
            count = count + 1
            total = total + 1
        else:
            total = total + 1

    print("the n-th palindrom number of " , count , " is: ", total - 1)