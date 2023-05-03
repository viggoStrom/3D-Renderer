import numpy as np

vertices = []

numLats = 20
numLongs = 40

theta = np.linspace(0, np.pi, numLats)
phi = np.linspace(0, 2*np.pi, numLongs)

theta_grid, phi_grid = np.meshgrid(theta, phi)

x = np.sin(theta_grid) * np.sin(phi_grid)
y = np.cos(theta_grid)
z = np.sin(theta_grid) * np.cos(phi_grid)

vertices = np.stack((x, y, z), axis=-1).reshape(-1, 3)


output = f"new double[{numLats*numLongs}, 3]\n\t\t\t{{\n"

for xyz in vertices:
    output += f"\t\t\t\t{{{xyz[0],xyz[1],xyz[2]}}},\n"

output += "\t\t\t};"

output = output.replace("(", "")
output = output.replace(")", "")

with open("output.txt", "w") as file:
    file.write(output)
