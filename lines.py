lines = int(input())

for i in range(1,lines+1):
    #print(lines-i+1)
    #print(" "*(lines-i+1), end="")
    #print("*"*(i*2-1))

    #print(" "*(i-1), end="")
    #print("*" * ((lines - i + 1) * 2 - 1))


    print(" "*(i-1), end="")
    print("*" * ((lines - i + 2) * 2 - 2))