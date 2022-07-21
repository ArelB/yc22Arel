import Test

def myFunction() : 
    print("Helooooo")


number = 10;
#print(number)
#sentence = "Hello, I am ";
#print (sentence + str(number))
#response = input("How are you?")
#print(response)

weekday = "Monday"

#if weekday == "Monday" :
 #   print("It is Monday")
#else :
  #  print ("Not Monday")

#for x in range(10):
 #   print(x)

getallen = [5,4,9,12,17]

for y in getallen:
    print(y)

Test.testMe("Chicken");

class Employee:
    firstName = "Mujishi"
    Age = 24
    def work(_self): #needs reference to itself to work for example _self.Age
        print("Helooooo I can work")

w1 = Employee()
print(w1.firstName)

class Child(Employee):
    party = "yes"
    def __init__(self, firstName, Age):
        print("Hello my name is " + firstName + "and I am " + str(Age)  + "years old")

c = Child("Arel", 29)
c.work()
