
# A utility function to print an 
# array p[] of size 'n' 
def printArray(p, n): 
    for i in range (0, n):
        for j in range(0, i):
            if(p[i] == p[j]):
                return
    for i in range(0, n):
        print(p[i], end = " ") 
    print() 
  
def printAllUniqueParts(n): 
    p = [0] * n    
    k = 0         
    p[k] = n     
                  
  
   
    while True: 
          
          # print current partition 
            printArray(p, k + 1) 
  
          
  
           # Find the rightmost non-one value in p[]. 
            rem_val = 0
            while k >= 0 and p[k]==1: 
                rem_val += p[k] 
                k -= 1
  # if k < 0, all the values are 1 so  
            # there are no more partitions 
            if k < 0: 
                print() 
                return
  
           
            # Decrease the p[k] found above  
            # and adjust the rem_val 
            p[k] -= 1 
            rem_val += 1
  
         # If rem_val is more, then the sorted  
            # order is violated. Divide rem_val in  
            # different values of size p[k] and copy  
            # these values at different positions after p[k] 
            while rem_val > p[k]: 
                p[k+1]=p[k]
                rem_val = rem_val - p[k] 
                k += 1
   # Copy rem_val to next position  
            # and increment position 
            p[k + 1] = rem_val 
            k += 1
  

