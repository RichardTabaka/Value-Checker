#This program will be used to calculate the value, in dollars per hour, of every subscription you have.
#It will prompt you for the name of each subscription you have, then the cost for LAST MONTH, then the time
#you spent using it LAST MONTH.
#
#In the future I'd like to add values of non-subscription content like a hard copy of a movie that would take the cost,
#length and how many times you have watched it to allow a comparison in usage of bought VS borrowed media
#------------------------------------------------------------------------------------------------------------------------

#The following explains the program in the console
print("Welcome to the Subscription Value Calculator!")
print("")
print("First, the program will prompt you to input a name, cost and your total hours using a subscription.")
print("Then it will move on to a second, third etc. When you are done entering subscriptions simply")
print(" enter 'No' when prompted for another to see the values.")
print()
subNames = []
subCosts = []
subTime = []
subValue = []
subCounter = []
j = 1

#This part takes your first subscriptions information

subNames.append(input("What is the Name of your first subscription? "))
subCosts.append(float(input("What is the cost of your first subscription? ")))
subTime.append(float(input("How much time did you spend using your first subscription? ")))
subCounter.append(0)
subValue.append(float(subTime[0] / subCosts[0]))
print("")
cont = input("Would you like to enter another subscription?('Yes' or 'No') ")
print("")

#The following allows the user to input as many subscriptions as they would like to check
#simply responding with 'No' exits the while loop
while cont != "No":
    subNames.append(input("What is the Name of your next subscription? "))
    subCosts.append(float(input("What is the cost of this subscription? ")))
    subTime.append(float(input("How much time did you spend using this subscription? ")))
    subCounter.append(j)
    subValue.append(float(subTime[j] / subCosts[j]))
    print("")
    cont = input("Would you like to enter another subscription?('Yes' or 'No') ")
    j += 1
    print("")

#This prints the name and value of every subscription entered
print("Your Subscriptions:")
print("")
print("   Name                Value(Hours/Dollar Spent)")
print("   ---------------------------------------------")
print("")
sp =  "                            "
for i in subCounter:
    z = str(round(subValue[i], 3))
    print("   " + subNames[i] + sp[len(subNames[i]):(len(sp)-5)] + z)
    print("")

#Hopefully this helped you re-evaluate your spending habits and cut subscriptions you don't use!