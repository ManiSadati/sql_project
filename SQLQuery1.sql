CREATE DATABASE Dbproject;
USE Dbproject;

CREATE TABLE SIGNUP
(
ID int identity(1,1) not null primary key,
firstname varchar(800) not null,
secondname varchar(800) not null,
email varchar(800) not null,
pass varchar(800) not null,
phone varchar(800) not null
);

CREATE TABLE employee
(
ID int not null primary key,
CID int not null,
Ctype varchar(800) null,
firstname varchar(800) not null,
lastname varchar(800) not null,
email varchar(800) not null,
pass varchar(800) not null,
phone varchar(800) not null,
worktime int null,
payment int null,
);

DROP TABLE employee;

CREATE TABLE player
(
ID int identity(1,1) not null primary key,
PID int foreign key,
Ctype varchar(800) null,
Ngame varchar(800) not null,
Ngoal varchar(800) not null,
HP varchar(800) not null,
Val varchar(800) not null,
);

CREATE TABLE customer
(
ID int identity(1,1) not null primary key,
NationalID varchar(100) not null,
Address varchar(800) not null,
Name varchar(800) not null,
Credit int not null
);

DROP TABLE SIGNUP;