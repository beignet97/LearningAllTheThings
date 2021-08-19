CREATE TABLE employees (
id INTEGER PRIMARY KEY,
name TEXT,
role_id INTEGER FOREIGN KEY REFERENCES roles(id),
manager_id INTEGER
);
