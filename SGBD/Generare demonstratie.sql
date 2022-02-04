create database if not exists bazadedate;


create table if not exists Adresa(
    id_adresa int(10) NOT NULL,
    nume_strada varchar(50),
    oras varchar(50),
    judet varchar(50),
    tara varchar(50),
    PRIMARY KEY (id_adresa)
);

create table if not exists Spital (
  nume_spital varchar(50) NOT NULL,
  id_adresa int(10) NOT NULL,
  foreign key (id_adresa) references Adresa(id_adresa),
  PRIMARY KEY (nume_spital)
);

create table if not exists Personal (
  nume_angajat varchar(50) NOT NULL,
  prenume_angajat varchar(50) NOT NULL,
  nume_spital varchar(50) NOT NULL,
  salariu int(10) NOT NULL,
  data_nasterii date NOT NULL,
  telefon varchar(15),
  foreign key (nume_spital) references Spital(nume_spital),
  PRIMARY KEY (nume_angajat, prenume_angajat)
);

create table if not exists Pacienti (
  an_nastere int(4) NOT NULL,
  zi_nastere int(4) NOT NULL,
  nume_spital varchar(50) NOT NULL,
  nume_pacient varchar(50) NOT NULL,
  prenume_pacient varchar(50) NOT NULL,
  telefon varchar(15),
  asigurat int(1) NOT NULL,
  foreign key (nume_spital) references Spital(nume_spital),
  PRIMARY KEY (an_nastere, zi_nastere)
);

create table if not exists Medicamente(
  denumire_medicament varchar(50) NOT NULL,
  pret int(10) NOT NULL,
  PRIMARY KEY (denumire_medicament)
);

create table if not exists Retete(
  id_reteta int(10) NOT NULL,
  an_nastere int(4) NOT NULL,
  zi_nastere int(4) NOT NULL,
  denumire_medicament varchar(50) NOT NULL,
  data_emiterii date NOT NULL,
  foreign key (an_nastere, zi_nastere) references Pacienti(an_nastere, zi_nastere),
  foreign key (denumire_medicament) references Medicamente(denumire_medicament),
  PRIMARY KEY (id_reteta)
);

create table if not exists Ustensile(
  denumire_ustensila varchar(50) NOT NULL,
  numar_unitati int(10) NOT NULL
);

INSERT INTO Adresa(id_adresa, nume_strada, oras, judet, tara)
VALUES (1,'Calea Floreasca 8', 'Bucuresti', 'Bucuresti', 'Romania');

INSERT INTO Adresa(id_adresa, nume_strada, oras, judet, tara)
VALUES (2,'Bulevardul Constantin Brancoveanu', 'Bucuresti', 'Bucuresti', 'Romania');

INSERT INTO Adresa(id_adresa, nume_strada, oras, judet, tara)
VALUES (3,'Bulevardul Ferdinand', 'Constanta', 'Constanta', 'Romania');

INSERT INTO Adresa(id_adresa, nume_strada, oras, judet, tara)
VALUES (4,'Calea București 258', 'Bucuresti', 'Bucuresti', 'Romania');

INSERT INTO Adresa(id_adresa, nume_strada, oras, judet, tara)
VALUES (5,'Bulevardul Mamaia 477', 'Constanta', 'Constanta', 'Romania');

INSERT INTO Adresa(id_adresa, nume_strada, oras, judet, tara)
VALUES (6,'Str. Clinicilor 3-5', 'Cluj-Napoca', 'Cluj', 'Romania');

INSERT INTO Adresa(id_adresa, nume_strada, oras, judet, tara)
VALUES (7,'Strümpellstraße 41', 'Leipzig', '', 'Germania');



INSERT INTO Spital(nume_spital, id_adresa)
VALUES ('Spitalul Clinic de Urgenta Bucuresti', 1);

INSERT INTO Spital(nume_spital, id_adresa)
VALUES ('Institutul Clinic Fundeni', 4);

INSERT INTO Spital(nume_spital, id_adresa)
VALUES ('Spitalul Clinic de Copii Marie Skłodowska Curie', 2);

INSERT INTO Spital(nume_spital, id_adresa)
VALUES ('Spitalul Clinic de Boli Infecțioase', 3);

INSERT INTO Spital(nume_spital, id_adresa)
VALUES ('Helios Park-Klinikum Leipzig', 7);

INSERT INTO Spital(nume_spital, id_adresa)
VALUES ('Spitalul Clinic Județean de Urgență Cluj', 6);


INSERT INTO Pacienti(an_nastere, zi_nastere, nume_spital, nume_pacient, prenume_pacient,telefon, asigurat)
VALUES (1980, 5, 'Spitalul Clinic Județean de Urgență Cluj', 'Popa', 'Alexandru', ('0726594753'), 1);

INSERT INTO Pacienti(an_nastere, zi_nastere, nume_spital, nume_pacient, prenume_pacient,telefon, asigurat)
VALUES (1980, 23, 'Spitalul Clinic de Urgenta Bucuresti', 'Popescu', 'Alexandru', ('0726395513'), 1);


INSERT INTO Medicamente(denumire_medicament, pret)
VALUES ("PAEOTITA", 90);

INSERT INTO Medicamente(denumire_medicament, pret)
VALUES ("BDOTITA", 91);

INSERT INTO Medicamente(denumire_medicament, pret)
VALUES ("PCCOTITA", 42);

INSERT INTO Ustensile(denumire_ustensila, numar_unitati)
VALUES ("Stetoscop", 3);

INSERT INTO Ustensile(denumire_ustensila, numar_unitati)
VALUES ("Bisturiu", 3);


