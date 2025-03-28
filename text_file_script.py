with open("users.txt", "r") as file:
    for line in file:
        if "admin" in line:
            print(line.strip())
