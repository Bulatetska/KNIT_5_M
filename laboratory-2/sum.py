inp = input("Provide a number")
def a_func(arg):
    sum = 0
    for digit in str(arg):
        sum += int(digit)
    print(f"{sum} is sum ")
a_func(inp)

