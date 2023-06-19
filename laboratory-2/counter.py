inp = input("Provide a number")
def a_func(arg):
    total = len(str(arg))
    sum = 0
    for digit in str(arg):
      sum += int(digit)
    print(f"{sum} is total and number of digits is {total}")
a_func(inp)

