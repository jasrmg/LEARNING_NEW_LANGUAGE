import hashlib

def hash_password(password, salt=""):
  combined = salt + password
  return hashlib.sha256(combined.encode()).hexdigest()

password = "pass123"
password_typo = "pass124"
salt = "asd"
salt2 = "zxc"

print("WITHOUT SALT")
print(f"password: {password} -> {hash_password(password)}")
print(f"password typo: {password_typo} -> {hash_password(password_typo)}")

print("WITH SALT")
print(f"password: {password} -> {hash_password(password, salt)}")
print(f"password different salt: {password} -> {hash_password(password, salt2)}")
print(f"password typo: {password_typo} -> {hash_password(password_typo, salt)}")