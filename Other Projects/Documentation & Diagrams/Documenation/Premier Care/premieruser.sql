/*
01 Create Account
Create accounts for HR schema
Run this as either SYS or SYSTEM.
*/


/*
Set the pluggable database if you're running this on Oracle v12 or later.
*/
ALTER SESSION SET CONTAINER = XEPDB1;

/*
Drop the HR account and all objects to reset.
Then, create the user and give it the permissions.
*/
DROP USER premier CASCADE;

CREATE USER premier IDENTIFIED BY premiercare;

ALTER USER premier DEFAULT TABLESPACE users QUOTA UNLIMITED ON users;

ALTER USER premier TEMPORARY TABLESPACE TEMP;

GRANT CONNECT TO premier;

GRANT CREATE SESSION, CREATE VIEW, CREATE TABLE, ALTER SESSION, CREATE SEQUENCE TO premier;
GRANT CREATE SYNONYM, CREATE DATABASE LINK, RESOURCE, UNLIMITED TABLESPACE TO premier;
