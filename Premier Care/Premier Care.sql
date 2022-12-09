--Changed the amount of bytes the date stores and changed the data data type to varchar for simplicity
--Start from the bottom go to the top to drop tables, only create patient tables and appointment

drop sequence pat_num;
drop sequence appId;

CREATE SEQUENCE pat_num
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 10;

CREATE SEQUENCE appID
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 10;

drop table patientDetails CASCADE CONSTRAINTS;
--PatientDetails Table
CREATE TABLE PatientDetails(
    pat_num NUMBER PRIMARY KEY,
    name VARCHAR2(20) NOT NULL,
    address VARCHAR2(150) NOT NULL,
    DOB VARCHAR2(20) NOT NULL,
    allergies VARCHAR2(100),
    bloodType VARCHAR2(100) NOT NULL
);

drop table appointment CASCADE CONSTRAINTS;
--Appointment Bridge Table
CREATE TABLE Appointment (
    appID NUMBER PRIMARY KEY,
    pat_num NUMBER,
    time DATE,
    particular VARCHAR(100),
    FOREIGN KEY(pat_num) REFERENCES PatientDetails(pat_num)
);

drop table doctor CASCADE CONSTRAINTS;
--Doctor Table <<SUB CLASS OF STAFF>>
CREATE TABLE DOCTOR(
    staffID NUMBER PRIMARY KEY NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);
drop table nurse CASCADE CONSTRAINTS;
--Nurse Table <<SUB CLASS OF STAFF>>
CREATE TABLE NURSE(
    staffID NUMBER PRIMARY KEY NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);
drop table technician CASCADE CONSTRAINTS;
--Technician Table <<SUB CLASS OF STAFF AND SUPER CLASS OF LAB AND X-RAY>> 
CREATE TABLE Technician(
    staffID NUMBER NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);
drop table lab CASCADE CONSTRAINTS;
CREATE TABLE Lab(
     staffID NUMBER NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);
drop table xray CASCADE CONSTRAINTS;
CREATE TABLE XRay(
    staffID NUMBER NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);
drop table therapist CASCADE CONSTRAINTS;
--Therapist Table <<SUB CLASS OF STAFF>>
CREATE TABLE Therapist(
    staffID NUMBER PRIMARY KEY NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);

drop table csr CASCADE CONSTRAINTS;
--CSR Table <<SUB CLASS OF STAFF>>
CREATE TABLE CSR(
    staffID NUMBER PRIMARY KEY NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);

drop table drug CASCADE CONSTRAINTS;
--RAUSHAWN CODE
CREATE TABLE DRUG(
AMOUNT NUMBER(20),
INTAKE VARCHAR(20),
COST NUMBER(20),
PAT_NUM NUMBER,
FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
);

drop table service CASCADE CONSTRAINTS;
  CREATE TABLE SERVICE(   
    SERVE_TYPE VARCHAR(20),
    UNITCOST NUMBER(20),
    PAT_NUM NUMBER,
    PRIMARY KEY(SERVE_TYPE),
    FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(pat_num)
    );
    
  drop table pediatric CASCADE CONSTRAINTS;
        CREATE TABLE PEDIATRIC(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)

        );
        
        drop table general CASCADE CONSTRAINTS;
        CREATE TABLE GENERAL(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        
        );
        drop table practice CASCADE CONSTRAINTS;
        CREATE TABLE PRACTICE(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        );
        drop table x_ray CASCADE CONSTRAINTS;
        CREATE TABLE X_RAY(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        );
        drop table specialist CASCADE CONSTRAINTS;
        CREATE TABLE SPECIALIST(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        );
        drop table LABORATORY CASCADE CONSTRAINTS;
        CREATE TABLE LABORATORY(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        );
        
        drop table therapy CASCADE CONSTRAINTS;
        CREATE TABLE THERAPY(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        );
        
  drop table invoice CASCADE CONSTRAINTS;
CREATE TABLE INVOICE(
INVOICEID NUMBER,
SERVE_TYPE VARCHAR(20),
COST NUMBER(20),
PAT_NUM NUMBER,
PRIMARY KEY(INVOICEID),
FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
);
drop table treatment CASCADE CONSTRAINTS;
CREATE TABLE TREATMENT(
INVOICEID NUMBER,
FOREIGN KEY(INVOICEID) REFERENCES INVOICE(INVOICEID));

 
--Correct
INSERT INTO patientDetails VALUES (pat_num.nextval, 'Jonathan Grant', 'St. James', '17-JAN-2005', 'Banana', 'B');
INSERT INTO patientDetails VALUES (pat_num.nextval, 'Josiah Lawrence', 'Port of Spain', '19-Jul-2002', null, 'A');
INSERT INTO patientDetails VALUES (pat_num.nextval, 'Shannon Singh', 'Port of Spain', '29-Sep-1984', null, 'A');
INSERT INTO patientdetails values(pat_num.nextval, 'Aaron Hazzard', 'POS', '23/12/2002', 'Cats', 'A');
INSERT INTO patientdetails values(pat_num.nextval, 'Raushawn Mitchel', 'St james', '1/2/2003', 'Peanuts', 'B');

INSERT INTO Appointment (APPID, PAT_NUM, TIME, PARTICULAR) VALUES (appID.nextval, 1,  '1-JAN-2022',  'Sick');
INSERT INTO Appointment (APPID, PAT_NUM,TIME, PARTICULAR) VALUES (appID.nextval, 2,'2-JAN-2022', 'Ingury');
INSERT INTO Appointment (APPID, PAT_NUM, TIME, PARTICULAR) VALUES (appID.nextval, 3,  '5-JUL-2022', 'Chest pain');
INSERT INTO Appointment (APPID, PAT_NUM, TIME, PARTICULAR) VALUES (appID.nextval, 4,  '15-JUL-2022', 'Cough');
INSERT INTO Appointment (APPID, PAT_NUM, TIME, PARTICULAR) VALUES (appID.nextval, 5,  '15-JUL-2022', 'Visit');


INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (100, 'Donald', 'Doctor', 'Cocorite', 'HR', 10);
INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (200, 'Trump', 'Nurse', 'POS', 'HVC', 20);
INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (300, 'Jake', 'Lab Technician', 'Cocorite', 'I.T', NULL);
INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (400, 'Paul', 'Therapist', 'Cocorite', 'Therapy', 40);
INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (500, 'Dona', 'CSR', 'San Fernanao', 'Accounting', 50);
INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (600, 'Sharon', 'X-Ray Technician', 'Cocorite', 'I.T', NULL);

INSERT INTO CSR VALUES(5);

INSERT INTO DOCTOR VALUES (1);
INSERT INTO NURSE VALUES (2);
INSERT INTO Lab VALUES (3);
INSERT INTO Therapist VALUES (4);
INSERT INTO XRAY VALUES (6);



--Correct
INSERT INTO DRUG (amount,intake,cost, pat_num) VALUES(20,'twice a day',50, 1);
INSERT INTO DRUG (amount,intake,cost, pat_num) VALUES(50,'three times a week',20, 2);
INSERT INTO DRUG (amount,intake,cost, pat_num) VALUES(10,'once a day',30, 3);

   

INSERT INTO SERVICE (serve_type, unitcost, pat_num) VALUES ('Therapist', 150, 1);
INSERT INTO SERVICE (serve_type, unitcost, pat_num) VALUES ('Laboratory', 300, 2);
INSERT INTO SERVICE (serve_type, unitcost, pat_num) VALUES ('General', 50, 3);
INSERT INTO SERVICE (serve_type, unitcost, pat_num) VALUES ('Pediatric', 200, 4);
INSERT INTO SERVICE (serve_type, unitcost, pat_num) VALUES ('Xray', 500,  5);
INSERT INTO SERVICE (serve_type, unitcost, pat_num) VALUES ('Practice', 0,  5);
INSERT INTO SERVICE (serve_type, unitcost, pat_num) VALUES ('Specialist', 300,  3);

INSERT INTO PEDIATRIC VALUES ('Pediatric', 'Jake', 200);
INSERT INTO GENERAL VALUES ('General', 'Hanner', 300);
INSERT INTO PRACTICE VALUES ('Practice', 'Kate', 100);
INSERT INTO X_RAY VALUES ('Xray', 'Paul', 500);
INSERT INTO SPECIALIST VALUES ('Specialist', 'Pete', 400);
INSERT INTO LABORATORY VALUES ('Laboratory', 'Dr. Frank', null);
INSERT INTO THERAPY VALUES ('Therapist', 'Dr. Bob', null);

   

--Correct
INSERT INTO INVOICE  VALUES(1,'Therapist',200, 1);
INSERT INTO INVOICE  VALUES(2,'Xray',100, 2);
INSERT INTO INVOICE  VALUES(3,'Specialist',150, 3);
INSERT INTO INVOICE  VALUES(4,'Pediatric',450, 4);
INSERT INTO INVOICE  VALUES(5,'General',650, 5);



--Correct
INSERT INTO treatment (INVOICEID) VALUES(1);
INSERT INTO treatment (INVOICEID) VALUES(2);
INSERT INTO treatment (INVOICEID) VALUES(3);
INSERT INTO treatment (INVOICEID) VALUES(4);
INSERT INTO treatment (INVOICEID) VALUES(5);




