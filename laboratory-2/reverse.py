inp = input("Provide a number")
def reverse_number(number):
    if type(number) == int:
        return int(str(number)[::-1])
    else:
        print('Not an integer')

reverse_number(inp)

