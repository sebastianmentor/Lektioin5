import subprocess

target = "8.8.8.8"
result = subprocess.run(["ping", "-c", "4", target], capture_output=True, text=True)

print(result.stdout)
