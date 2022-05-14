print ('Лямбада-функция, которая удваивает свой аргумент')
my_list = [10, 20, 30, 40, 50, 60]
new_list = list(map(lambda x: x*2, my_list))
print(new_list) 
print ('________________________________________')

print ('Лямбада-функция, которая умешьшает в двое свой аргумент')
my_list = [10, 20, 40, 60, 80]
new_list = list(map(lambda x: x/2, my_list))
print(new_list) 
print ('________________________________________')

print ('Лямбада-функция, которая ищет числа > 0')
my_list = [221, -32, 225, 0, -18, 222]
new_list = list(filter(lambda x: x > 0, my_list))
print(new_list)
print ('________________________________________')

print ('Лямбада-функция, которая ищет числа < 0')
my_list = [555, -21, 112, 0, -31, -51]
new_list = list(filter(lambda x: x < 0, my_list))
print(new_list)
print ('________________________________________')

print ('Лямбада-функция, которая ищет число = 21')
my_list = [221, 21, 112, 0, -21, -112]
new_list = list(filter(lambda x: x == 21, my_list))
print(new_list)
print ('________________________________________')


