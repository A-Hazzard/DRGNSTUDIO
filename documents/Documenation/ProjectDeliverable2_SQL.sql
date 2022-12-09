--PatientDetails Table
CREATE TABLE PatientDetails(
    pat_num NUMBER PRIMARY KEY,
    name VARCHAR2(20) NOT NULL,
    address VARCHAR2(150) NOT NULL,
    DOB date NOT NULL,
    allergies VARCHAR2(50),
    bloodType VARCHAR2(5) NOT NULL
);

--Correct
INSERT INTO patientDetails VALUES (pat#.nextval, 'Jonathan Grant', 'St. James', '17-JAN-2005', 'Banana', 'B');
INSERT INTO patientDetails VALUES (pat#.nextval, 'Josiah Lawrence', 'Port of Spain', '19-Jul-2002', null, 'A');
INSERT INTO patientDetails VALUES (pat#.nextval, 'Shannon Singh', 'Port of Spain', '29-Sep-1984', null, 'A');
INSERT INTO patientdetails values(pat#.nextval, 'Aaron Hazzard', 'POS', '23/12/2002', 'Cats', 'A');
INSERT INTO patientdetails values(pat#.nextval, 'Raushawn Mitchel', 'St james', '1/2/2003', 'Peanuts', 'B');

--Appointment Bridge Table
CREATE TABLE Appointment (
    appID NUMBER PRIMARY KEY,
    pat_num NUMBER,
    time DATE,
    particular VARCHAR(100),
    FOREIGN KEY(pat_num) REFERENCES PatientDetails(pat_num)
);

INSERT INTO Appointment (APPID, PAT_NUM, TIME, PARTICULAR) VALUES (10, 1,  '1-JAN-2022',  'Sick');
INSERT INTO Appointment (APPID, PAT_NUM,TIME, PARTICULAR) VALUES (20, 2,'2-JAN-2022', 'Ingury');
INSERT INTO Appointment (APPID, PAT_NUM, TIME, PARTICULAR) VALUES (30, 3,  '5-JUL-2022', 'Chest pain');
INSERT INTO Appointment (APPID, PAT_NUM, TIME, PARTICULAR) VALUES (40, 4,  '15-JUL-2022', 'Cough');
INSERT INTO Appointment (APPID, PAT_NUM, TIME, PARTICULAR) VALUES (50, 5,  '15-JUL-2022', 'Visit');


--STAFF Table <<SUPER CLASS>>
CREATE TABLE Staff(
    staffID NUMBER NOT NULL PRIMARY KEY,
    name VARCHAR(20) NOT NULL,
    type VARCHAR(25)  NOT NULL,
    address VARCHAR(50)  NOT NULL,
    department VARCHAR(20)  NOT NULL,
    appID NUMBER,
    FOREIGN KEY(appID) REFERENCES Appointment(appID)
);

INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (100, 'Donald', 'Doctor', 'Cocorite', 'HR', 10);
INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (200, 'Trump', 'Nurse', 'POS', 'HVC', 20);
INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (300, 'Jake', 'Lab Technician', 'Cocorite', 'I.T', NULL);
INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (400, 'Paul', 'Therapist', 'Cocorite', 'Therapy', 40);
INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (500, 'Dona', 'CSR', 'San Fernanao', 'Accounting', 50);
INSERT INTO staff (STAFFID, NAME, TYPE, ADDRESS, DEPARTMENT, APPID) VALUES (600, 'Sharon', 'X-Ray Technician', 'Cocorite', 'I.T', NULL);

--CSR Table <<SUB CLASS OF STAFF>>
CREATE TABLE CSR(
    staffID NUMBER PRIMARY KEY NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);

INSERT INTO CSR VALUES(5);

--Creating foreign key staffID in appointment table
ALTER TABLE Appointment
ADD (
StaffID NUMBER,
CSR_ID NUMBER,
FOREIGN KEY(StaffID) REFERENCES Staff(StaffID),
FOREIGN KEY(CSR_ID) REFERENCES CSR(StaffID)
);

UPDATE Appointment
SET staffid = 100;
WHERE APPID = 10;

UPDATE Appointment
SET staffid = 200
WHERE APPID = 20;

UPDATE Appointment
SET staffid = 300
WHERE APPID = 30;

UPDATE Appointment
SET staffid = 1
WHERE APPID = 4;

UPDATE Appointment
SET staffid = 1
WHERE APPID = 5;

UPDATE Appointment
SET CSR_ID = 5
WHERE APPID= 1;

UPDATE Appointment
SET CSR_ID = 5
WHERE APPID= 2;

UPDATE Appointment
SET CSR_ID = 5
WHERE APPID= 3;

UPDATE Appointment
SET CSR_ID = 5
WHERE APPID= 4;

UPDATE Appointment
SET CSR_ID = 5
WHERE APPID= 5;






--Doctor Table <<SUB CLASS OF STAFF>>
CREATE TABLE DOCTOR(
    staffID NUMBER PRIMARY KEY NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);

--Nurse Table <<SUB CLASS OF STAFF>>
CREATE TABLE NURSE(
    staffID NUMBER PRIMARY KEY NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);

--Technician Table <<SUB CLASS OF STAFF AND SUPER CLASS OF LAB AND X-RAY>> 
CREATE TABLE Technician(
    staffID NUMBER NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);

CREATE TABLE Lab(
     staffID NUMBER NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);

CREATE TABLE XRay(
    staffID NUMBER NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);

--Therapist Table <<SUB CLASS OF STAFF>>
CREATE TABLE Therapist(
    staffID NUMBER PRIMARY KEY NOT NULL,
    FOREIGN KEY(staffID) REFERENCES STAFF(staffID)
);

INSERT INTO DOCTOR VALUES (1);
INSERT INTO NURSE VALUES (2);
INSERT INTO Lab VALUES (3);
INSERT INTO Therapist VALUES (4);
INSERT INTO XRAY VALUES (6);



--RAUSHAWN CODE
CREATE TABLE DRUG(
AMOUNT NUMBER(20),
INTAKE VARCHAR(20),
COST NUMBER(20),
PAT_NUM NUMBER,
FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
);

--Correct
INSERT INTO DRUG (amount,intake,cost, pat_num) VALUES(20,'twice a day',50, 1);
INSERT INTO DRUG (amount,intake,cost, pat_num) VALUES(50,'three times a week',20, 2);
INSERT INTO DRUG (amount,intake,cost, pat_num) VALUES(10,'once a day',30, 3);

     CREATE TABLE SERVICE(   
    SERVE_TYPE VARCHAR(20),
    UNITCOST NUMBER(20),
    PAT_NUM NUMBER,
    PRIMARY KEY(SERVE_TYPE),
    FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(pat_num)
    );
  
        CREATE TABLE PEDIATRIC(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)

        );
        
        CREATE TABLE GENERAL(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        
        );
        
        CREATE TABLE PRACTICE(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        );
        
        CREATE TABLE X_RAY(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        );
        
        CREATE TABLE SPECIALIST(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        );
        
        CREATE TABLE LABORATORY(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        );
        
        CREATE TABLE THERAPY(
        SERVE_TYPE VARCHAR(20),
        WORKER VARCHAR(20),
        PAT_NUM NUMBER,
        FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
        FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
        );
        

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

   
    
CREATE TABLE INVOICE(
INVOICEID NUMBER,
SERVE_TYPE VARCHAR(20),
COST NUMBER(20),
PAT_NUM NUMBER,
PRIMARY KEY(INVOICEID),
FOREIGN KEY(SERVE_TYPE) REFERENCES SERVICE(SERVE_TYPE),
FOREIGN KEY(PAT_NUM) REFERENCES PatientDetails(PAT_NUM)
);

--Correct
INSERT INTO INVOICE  VALUES(1,'Therapist',200, 1);
INSERT INTO INVOICE  VALUES(2,'Xray',100, 2);
INSERT INTO INVOICE  VALUES(3,'Specialist',150, 3);
INSERT INTO INVOICE  VALUES(4,'Pediatric',450, 4);
INSERT INTO INVOICE  VALUES(5,'General',650, 5);


CREATE TABLE TREATMENT(
INVOICEID NUMBER,
FOREIGN KEY(INVOICEID) REFERENCES INVOICE(INVOICEID));

--Correct
INSERT INTO treatment (INVOICEID) VALUES(1);
INSERT INTO treatment (INVOICEID) VALUES(2);
INSERT INTO treatment (INVOICEID) VALUES(3);
INSERT INTO treatment (INVOICEID) VALUES(4);
INSERT INTO treatment (INVOICEID) VALUES(5);





