score = int(input("Please Enter Your score : "))

if score < 0 :
    print("error")
elif score >= 50 and score < 60:
    print("D")
elif score >= 60 and score < 70:
    print("C")
elif score >= 70 and score < 80:
    print("B")
elif score >= 80:
    print("A")
else:
    print("error")


