import math

def format_vec(v):
    return "(" + ", ".join(str(round(x, 2)) if isinstance(x, float) else str(x) for x in v) + ")"

def format_mat(m):
    return "\n".join("(" + ", ".join(str(round(x, 2)) if isinstance(x, float) else str(x) for x in row) + ")" for row in m)

# 0-pythagoras
ac = math.sqrt(64**2 + 121**2)
print(f"0: {round(ac, 2)}")

# 1-magnitude_2D
v1 = (3, 9)
mag1 = math.sqrt(sum(x*x for x in v1))
print(f"1: {round(mag1, 2)}")

# 2-magnitude_3D
v2 = (7, -3, -9)
mag2 = math.sqrt(sum(x*x for x in v2))
print(f"2: {round(mag2, 2)}")

# 4-vector_addition_2D
v4 = (8, -11)
u4 = (-4, 9)
res4 = (v4[0]+u4[0], v4[1]+u4[1])
print(f"4: {format_vec(res4)}")

# 5-vector_addition_3D
v5 = (14, -2, 0)
u5 = (-3, 23, 50)
res5 = (v5[0]+u5[0], v5[1]+u5[1], v5[2]+u5[2])
print(f"5: {format_vec(res5)}")

# 7-vector_scalar_mul_2D
v7 = (98, 972)
x7 = 0.5
res7 = (v7[0]*x7, v7[1]*x7)
print(f"7: {format_vec(res7)}")

# 8-vector_scalar_mul_3D
v8 = (0, -16, 31)
x8 = 4
res8 = (v8[0]*x8, v8[1]*x8, v8[2]*x8)
print(f"8: {format_vec(res8)}")

# 10-dot_product_2D
v10 = (1, 3)
u10 = (-2, 5)
res10 = v10[0]*u10[0] + v10[1]*u10[1]
print(f"10: {res10}")

# 11-dot_product_3D
v11 = (-4, 0, 10)
u11 = (3, 7, -9)
res11 = v11[0]*u11[0] + v11[1]*u11[1] + v11[2]*u11[2]
print(f"11: {res11}")

# 13-matrix_addition
M13 = [[14, -3, 0], [-11, -5, 3], [2, -9, 13]]
N13 = [[6, 16, 21], [5, 2, 0], [1, 3, 7]]
res13 = [[M13[i][j] + N13[i][j] for j in range(3)] for i in range(3)]
print(f"13:\n{format_mat(res13)}")

# 15-matrix_scalar_mul
M15 = [[-13, 10, 8], [2, 0, 14], [-4, -5, 2]]
x15 = 4
res15 = [[M15[i][j] * x15 for j in range(3)] for i in range(3)]
print(f"15:\n{format_mat(res15)}")

# 17-matrix_matrix_mul
M17 = [[2, 3], [-1, 0]]
N17 = [[1, 7], [-8, -2]]
res17 = [[sum(M17[i][k] * N17[k][j] for k in range(2)) for j in range(2)] for i in range(2)]
print(f"17:\n{format_mat(res17)}")

# 19-matrix_rotate_2D
M19 = [[1, 2], [3, 4]]
theta = -1.57
cos_t = math.cos(theta)
sin_t = math.sin(theta)
# Rotation of row vectors
res19 = []
for row in M19:
    x, y = row
    res19.append([x * cos_t - y * sin_t, x * sin_t + y * cos_t])
print(f"19:\n{format_mat(res19)}")

# 21-matrix_shear_2D (file 23-matrix_shear_2D)
M21 = [[1, 2], [3, 4]]
s21 = 2
# Shear in X: x' = x + sy, y' = y
res21 = []
for row in M21:
    x, y = row
    res21.append([x + s21 * y, y])
print(f"21:\n{format_mat(res21)}")

# 24-determinant_2D (file 26-determinant_2D)
M24 = [[2, 2], [-9, 4]]
det24 = M24[0][0]*M24[1][1] - M24[0][1]*M24[1][0]
print(f"24: {det24}")

# 25-determinant_3D (file 27-determinant_3D)
M25 = [[-4, 9, 0], [1, -2, 1], [3, -4, 2]]
def det3x3(m):
    return (m[0][0] * (m[1][1]*m[2][2] - m[1][2]*m[2][1]) -
            m[0][1] * (m[1][0]*m[2][2] - m[1][2]*m[2][0]) +
            m[0][2] * (m[1][0]*m[2][1] - m[1][1]*m[2][0]))
det25 = det3x3(M25)
print(f"25: {det25}")

# 27-cross_product (file 29-cross_product)
v27 = (2, -2, 1)
u27 = (-8, 8, -4)
res27 = (v27[1]*u27[2] - v27[2]*u27[1],
         v27[2]*u27[0] - v27[0]*u27[2],
         v27[0]*u27[1] - v27[1]*u27[0])
print(f"27: {format_vec(res27)}")

# 29-inverse_2D (file 31-inverse_2D)
M29 = [[1, 2], [3, 4]]
det29 = M29[0][0]*M29[1][1] - M29[0][1]*M29[1][0]
inv29 = [[M29[1][1]/det29, -M29[0][1]/det29], [-M29[1][0]/det29, M29[0][0]/det29]]
print(f"29:\n{format_mat(inv29)}")

# 30-inverse_3D (file 32-inverse_3D)
M30 = [[11, 8, 7], [2, 13, 1], [4, 0, 17]]
det30 = det3x3(M30)
def inverse3x3(m):
    d = det3x3(m)
    adj = [[0,0,0],[0,0,0],[0,0,0]]
    adj[0][0] = (m[1][1]*m[2][2] - m[1][2]*m[2][1])
    adj[0][1] = -(m[0][1]*m[2][2] - m[0][2]*m[2][1])
    adj[0][2] = (m[0][1]*m[1][2] - m[0][2]*m[1][1])
    adj[1][0] = -(m[1][0]*m[2][2] - m[1][2]*m[2][0])
    adj[1][1] = (m[0][0]*m[2][2] - m[0][2]*m[2][0])
    adj[1][2] = -(m[0][0]*m[1][2] - m[0][2]*m[1][0])
    adj[2][0] = (m[1][0]*m[2][1] - m[1][1]*m[2][0])
    adj[2][1] = -(m[0][0]*m[2][1] - m[0][1]*m[2][0])
    adj[2][2] = (m[0][0]*m[1][1] - m[0][1]*m[1][0])
    return [[x/d for x in row] for row in adj]
inv30 = inverse3x3(M30)
print(f"30:\n{format_mat(inv30)}")
