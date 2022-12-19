INSERT INTO DRUG (amount,intake,cost) VALUES(20,'twice a day',50);
INSERT INTO DRUG (amount,intake,cost) VALUES(50,'three times a week',20);
INSERT INTO DRUG (amount,intake,cost) VALUES(10,'once a day',30);

INSERT INTO INVOICE (invoiceid,serv_type#,cost) VALUES(100,20,200);
INSERT INTO INVOICE (invoiceid,serv_type#,cost) VALUES(101,30,100);
INSERT INTO INVOICE (invoiceid,serv_type#,cost) VALUES(102,40,150);

INSERT INTO SERVICE (serv_type, unitcost) VALUES ('Therapy', 150);
INSERT INTO SERVICE (serv_type, unitcost) VALUES ('Laboratory', 300);
INSERT INTO SERVICE (serv_type, unitcost) VALUES ('General', 50);
INSERT INTO SERVICE (serv_type, unitcost) VALUES ('Pediatric', 200);
INSERT INTO SERVICE (serv_type, unitcost) VALUES ('Xray', 500);
INSERT INTO SERVICE (serv_type, unitcost) VALUES ('Practice', 0);