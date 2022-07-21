import mysql.connector
import requests as req
import pandas


def FindPokemon(Poke):
    for index, pokemon in df.iterrows():
        if pokemon["Name"] == Poke:
            return pokemon

df = pandas.read_csv("Pokemon.csv")

input1 = input("Which is the first pokemon you want to choose?")
input2 = input("Which is the second pokemon you want to choose?")
pokemon1 = FindPokemon(input1)
pokemon2 = FindPokemon(input2)

if pokemon1["Attack"] > pokemon2["Attack"] :
    print(pokemon1["Name"])
else :
    print(pokemon2["Name"])

attack1 = int(pokemon1["Attack"])
attack2 = int(pokemon2["Attack"])
totalAttack = attack1 + attack2

print("Combined attack is:  " + str(totalAttack))

    
#def testMe(bla) :
    #print("Hello i am from test " + bla)
#print("it works")
""""  Database connection
myDB = mysql.connector.connect(
    host="localhost",
    user="root",
    password="",
    database="test"
)

myCursor = myDB.cursor();
myCursor.execute("Select * from python")

recordset = myCursor.fetchall()

for x in recordset:
    print(x)

sql = "INSERT INTO python (name, age) VALUES (%s,%s)" 
val = ("Banana", 29)
myCursor.execute(sql,val)
myDB.commit()
"""
"""" API connection
#If all good returns status code 200
result = req.get("https://catfact.ninja/facts")
catFact = result.json()
#print(catFact["data"][1])
count = 0
counts = 0
for x in catFact["data"] :
    print(x["fact"])
    count = count + x["fact"].count("cat")
    counts = counts + x["fact"].count("cats")

print(count)
print(counts)
"""

