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


CREATE TABLE coach
(
ID int not null primary key,
PID int not null,
Ngame int not null,
Ngoal int not null,
Nwin int not null,
Val int not null,
);

CREATE TABLE doctor
(
ID int not null primary key,
PID int not null,
major varchar(800) not null,
);


CREATE TABLE Customer
(
ID int identity(1,1) not null primary key,
Name varchar(800) not null,
NID varchar(100) not null,
email varchar(800) not null,
password varchar(800) not null,
Address varchar(800) not null,
Credit int not null
);


CREATE TABLE player
(
ID int not null primary key,
PID int not null,
Ngame int not null,
Ngoal int not null,
Nwin int not null,
age int not null,
health int not null,
val  int not null,
);

CREATE TABLE tournament
(
ID int not null primary key,
dname varchar(800) not null,
wteam varchar(800) not null,
drank int not null,
prise varchar(800) not null,
point int not null,
);

CREATE TABLE product
(
ID int not null primary key,
price int not null,
dname varchar(800) not null,
size int not null,
remain int not null,
);

CREATE TABLE play
(
playerid int not null,
gameid int not null,
ngoal int not null,
tplayed int not null,
npass int not null,
grade int not null,
ncpass int not null,
);

CREATE TABLE participate
(
gameid int not null primary key,
nrgoal int not null,
nsgoal int not null,
ncpass int not null,
ngattempt int not null,
phball int not null,
);

CREATE TABLE manager
(
ID int not null primary key,
dname varchar(800) not null,
experience varchar(800) not null,
task varchar(800) not null,
);

CREATE TABLE game
(
ID int not null primary key,
wteam varchar(800) not null,
referee varchar(800) not null,
nfans int not null,
opponent varchar(800) not null,
);

CREATE TABLE club
(
ID int not null primary key,
dname varchar(800) not null,
twork int not null,
income int not null,
val  int not null,
);



DROP TABLE employee;
DROP TABLE player;
DROP TABLE coach;
DROP TABLE doctor;

DROP TABLE SIGNUP;
USE Trash;
Drop Database Dbproject;
