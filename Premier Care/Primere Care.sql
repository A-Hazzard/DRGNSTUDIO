select * from USER_SEQUENCES;
drop sequence pat_num;
drop sequence appId;
drop sequence staffID;
drop sequence nurseID;
drop sequence doctorID;
drop sequence xray_tech_ID;
drop sequence lab_tech_ID;
drop sequence csrID;
drop sequence therapist;


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

CREATE SEQUENCE staffID
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 10;

CREATE SEQUENCE nurseID
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 10;

CREATE SEQUENCE xray_tech_ID
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 10;

CREATE SEQUENCE lab_tech_ID
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 10;

CREATE SEQUENCE therapist_ID
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 10;

CREATE SEQUENCE csr_ID
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 10;

CREATE SEQUENCE doctorID
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 10;

drop table patient CASCADE CONSTRAINTS;
--patient Table
CREATE TABLE patient(
    pat_num NUMBER PRIMARY KEY,
    name VARCHAR2(20) NOT NULL,
    phone VARCHAR2(150) NOT NULL,
    DOB VARCHAR2(20) NOT NULL,
    allergies VARCHAR2(100),
    bloodType VARCHAR2(100) NOT NULL
);
/*
CREATE TABLE invoice(
    pat_num VARCHAR(200) NOT NULL,
    invoice VARCHAR(150)
);*/
CREATE TABLE admin(
    email VARCHAR(20) PRIMARY KEY NOT NULL,
    password VARCHAR(8) NOT NULL
);
INSERT INTO admin VALUES('care@gmail.com', 'care123');
select * from admin;

DROP TABLE STAFF;
CREATE TABLE staff(
    ID NUMBER NOT NULL,
    Name VARCHAR2(30) NOT NULL,
    Email VARCHAR2(50) NOT NULL PRIMARY KEY,
    position VARCHAR2(12) NOT NULL
);
drop table appointment CASCADE CONSTRAINTS;
--Appointment Bridge Table
CREATE TABLE Appointment (
    appID NUMBER PRIMARY KEY,
    pat_num NUMBER NOT NULL,
    pat_name VARCHAR(20) NOT NULL,
    DOB  VARCHAR(20) NOT NULL,
    pat_phone  VARCHAR(10) NOT NULL,
    allergies  VARCHAR(20),
    bloodtype  VARCHAR(20) NOT NULL,
    --doctor info
    doc_name  VARCHAR(20) NOT NULL,
    doc_email  VARCHAR(20) NOT NULL,
    doc_position  VARCHAR(20) NOT NULL,
    doc_ID NUMBER NOT NULL,
    time VARCHAR(50) NOT NULL,
    particular VARCHAR(100),
    service VARCHAR(15) NOT NULL,
    fee NUMBER(120) NOT NULL,
        FOREIGN KEY(service) REFERENCES service(serve_type)
    FOREIGN KEY(doc_email) REFERENCES DOCTOR(email)
);
select * from appointment;

drop table doctor CASCADE CONSTRAINTS;
--Doctor Table <<SUB CLASS OF STAFF>>
CREATE TABLE DOCTOR(
    doctorID NUMBER NOT NULL,
   Name VARCHAR2(30) NOT NULL,
    Email VARCHAR2(50) NOT NULL PRIMARY KEY,
position VARCHAR2(20) NOT NULL, 
FOREIGN KEY(email) REFERENCES STAFF(email)
);
drop table nurse CASCADE CONSTRAINTS;
--Nurse Table <<SUB CLASS OF STAFF>>
CREATE TABLE NURSE(
    nurseID NUMBER NOT NULL,
    Name VARCHAR2(30) NOT NULL,
    Email VARCHAR2(50) NOT NULL PRIMARY KEY,
    position VARCHAR2(20) NOT NULL, 
    FOREIGN KEY(email) REFERENCES STAFF(email)
);
drop table technician CASCADE CONSTRAINTS;
--Technician Table <<SUB CLASS OF STAFF AND SUPER CLASS OF LAB AND X-RAY>> 
CREATE TABLE Technician(
     tech_ID NUMBER NOT NULL,
         Name VARCHAR2(30) NOT NULL,

Email VARCHAR2(50) NOT NULL PRIMARY KEY,
position VARCHAR2(20) NOT NULL, 
FOREIGN KEY(email) REFERENCES STAFF(email)
);
drop table lab CASCADE CONSTRAINTS;
CREATE TABLE Lab(
      lab_tech_ID NUMBER NOT NULL,
          Name VARCHAR2(30) NOT NULL,

Email VARCHAR2(50) NOT NULL PRIMARY KEY,
position VARCHAR2(20) NOT NULL, 
FOREIGN KEY(email) REFERENCES STAFF(email)
);
drop table xray CASCADE CONSTRAINTS;
CREATE TABLE XRay(
    xray_tech_ID NUMBER NOT NULL,
        Name VARCHAR2(30) NOT NULL,

Email VARCHAR2(50) NOT NULL PRIMARY KEY,
position VARCHAR2(20) NOT NULL, 
FOREIGN KEY(email) REFERENCES STAFF(email)
);
drop table therapist CASCADE CONSTRAINTS;
--Therapist Table <<SUB CLASS OF STAFF>>
CREATE TABLE Therapist(
     therapist_ID NUMBER NOT NULL,
         Name VARCHAR2(30) NOT NULL,

Email VARCHAR2(50) NOT NULL PRIMARY KEY,
position VARCHAR2(20) NOT NULL, 
FOREIGN KEY(email) REFERENCES STAFF(email)
);

drop table csr CASCADE CONSTRAINTS;
--CSR Table <<SUB CLASS OF STAFF>>
CREATE TABLE CSR(
     csrID NUMBER NOT NULL,
         Name VARCHAR2(30) NOT NULL,

Email VARCHAR2(50) NOT NULL PRIMARY KEY,
position VARCHAR2(20) NOT NULL, 
FOREIGN KEY(email) REFERENCES STAFF(email)
);

drop table drug CASCADE CONSTRAINTS;
--RAUSHAWN CODE
/*CREATE TABLE DRUG(
    AMOUNT NUMBER(20),
    INTAKE VARCHAR(20),
    COST NUMBER(20),
    pat_num NUMBER,
    FOREIGN KEY(pat_num) REFERENCES patient(pat_num)
    );
*/
drop table service CASCADE CONSTRAINTS;
  CREATE TABLE SERVICE(   
    SERVE_TYPE VARCHAR(20) PRIMARY KEY,
    UNITCOST NUMBER(20)
    );
    
    INSERT INTO service VALUES('PEDIATRIC', 120); 
    INSERT INTO service VALUES('GENERAL', 90); 
    INSERT INTO service VALUES('SPECIALIST', 400);
    INSERT INTO service VALUES('LABORATORY', 340); 
    INSERT INTO service VALUES('THERAPY', 120);
    INSERT INTO service VALUES('XRAY', 600);
    
  drop table pediatric CASCADE CONSTRAINTS;
        CREATE TABLE PEDIATRIC(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        pat_num NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(pat_num) REFERENCES patient(pat_num)

        );
        
        drop table general CASCADE CONSTRAINTS;
        CREATE TABLE GENERAL(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        pat_num NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(pat_num) REFERENCES patient(pat_num)
        
        );
        drop table practice CASCADE CONSTRAINTS;
        CREATE TABLE PRACTICE(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        pat_num NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(pat_num) REFERENCES patient(pat_num)
        );
        drop table x_ray CASCADE CONSTRAINTS;
        CREATE TABLE X_RAY(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        pat_num NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(pat_num) REFERENCES patient(pat_num)
        );
        drop table specialist CASCADE CONSTRAINTS;
        CREATE TABLE SPECIALIST(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        pat_num NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(pat_num) REFERENCES patient(pat_num)
        );
        drop table LABORATORY CASCADE CONSTRAINTS;
        CREATE TABLE LABORATORY(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        pat_num NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(pat_num) REFERENCES patient(pat_num)
        );
        
        drop table therapy CASCADE CONSTRAINTS;
        CREATE TABLE THERAPY(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        pat_num NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(pat_num) REFERENCES patient(pat_num)
        );
        
  drop table invoice CASCADE CONSTRAINTS;
CREATE TABLE INVOICE(
INVOICEID NUMBER,
SERVE_TYPE VARCHAR(20),
COST NUMBER(20),
pat_num NUMBER,
PRIMARY KEY(INVOICEID),
FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
FOREIGN KEY(pat_num) REFERENCES patient(pat_num)
);
drop table treatment CASCADE CONSTRAINTS;
CREATE TABLE TREATMENT(
INVOICEID NUMBER,
FOREIGN KEY(INVOICEID) REFERENCES INVOICE(INVOICEID));

 
--Correct
INSERT INTO patient VALUES (pat_num.nextval, 'Jonathan Grant', 'St. James', '17-JAN-2005', 'Banana', 'B');
INSERT INTO patient VALUES (pat_num.nextval, 'Josiah Lawrence', 'Port of Spain', '19-Jul-2002', null, 'A');
INSERT INTO patient VALUES (pat_num.nextval, 'Shannon Singh', 'Port of Spain', '29-Sep-1984', null, 'A');
INSERT INTO patient values(pat_num.nextval, 'Aaron Hazzard', 'POS', '23/12/2002', 'Cats', 'A');
INSERT INTO patient values(pat_num.nextval, 'Raushawn Mitchel', 'St james', '1/2/2003', 'Peanuts', 'B');

INSERT INTO Appointment (APPID, pat_num, TIME, PARTICULAR) VALUES (appID.nextval, 1,  '1-JAN-2022',  'Sick');
INSERT INTO Appointment (APPID, pat_num,TIME, PARTICULAR) VALUES (appID.nextval, 2,'2-JAN-2022', 'Ingury');
INSERT INTO Appointment (APPID, pat_num, TIME, PARTICULAR) VALUES (appID.nextval, 3,  '5-JUL-2022', 'Chest pain');
INSERT INTO Appointment (APPID, pat_num, TIME, PARTICULAR) VALUES (appID.nextval, 4,  '15-JUL-2022', 'Cough');
INSERT INTO Appointment (APPID, pat_num, TIME, PARTICULAR) VALUES (appID.nextval, 5,  '15-JUL-2022', 'Visit');


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

   

INSERT INTO SERVICE (serve_type, unitcost, pat_num) VALUES ('Therapist', 150, 4);
INSERT INTO SERVICE (serve_type, unitcost, pat_num) VALUES ('Laboratory', 300, 11);


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


*/

