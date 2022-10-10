use bazadedate;

INSERT INTO angajati(nume_angajat, cnp_angajat, email_angajat) 
VALUES("Fericitu Armand", 1950420407736, "farmand@gmail.com");

INSERT INTO angajati(nume_angajat, cnp_angajat, email_angajat) 
VALUES("Petrache Roxana", 2870413409855, "PetracheRox@gmail.com");

INSERT INTO angajati(nume_angajat, cnp_angajat, email_angajat) 
VALUES("Tanasius Iulian", 2870811409241, "diuliana@gmail.com");


INSERT INTO clienti(nume_client, cnp_client, telefon_client, email_client) 
VALUES("Zambitchi Samuel", 1900411405747, 0728958695, "zsamuel@gmail.com");

INSERT INTO clienti(nume_client, cnp_client, telefon_client, email_client) 
VALUES("Rosioru Cristian", 1900626405508, 0721894254, "RCRISTIAN@gmail.com");

INSERT INTO clienti(nume_client, cnp_client, telefon_client, email_client) 
VALUES("Simion Sorin", 1870604405916, 0721824214, "ssorin@gmail.com");




INSERT INTO utilizatori(id_angajat, nume_utilizator, parola, permisiuni) 
VALUES(5, "User", "parola", "Administrator");