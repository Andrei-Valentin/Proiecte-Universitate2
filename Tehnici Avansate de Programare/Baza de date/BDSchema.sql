create database if not exists bazadedate;
use bazadedate;


create table if not exists angajati(
    id_angajat int NOT NULL auto_increment primary key,
    nume_angajat varchar(255) NOT NULL,
    cnp_angajat bigint NOT NULL UNIQUE,
    email_angajat varchar(255) NOT NULL UNIQUE,
    post varchar(255),
    tarif_orar float,
    cale_imagine varchar(255)
    );



create table if not exists utilizatori(
    id_utilizator int NOT NULL auto_increment primary key,
    id_angajat int NOT NULL UNIQUE,
    nume_utilizator varchar(255) NOT NULL UNIQUE,
    parola varchar(255) NOT NULL,
    permisiuni varchar(255) NOT NULL,
    foreign key (id_angajat) references angajati (id_angajat)
    );




create table if not exists clienti(
    id_client int NOT NULL auto_increment primary key,
    nume_client varchar(255) NOT NULL,
    cnp_client bigint NOT NULL UNIQUE,
    telefon_client bigint NOT NULL UNIQUE,
    email_client varchar(255) NOT NULL UNIQUE
    );



create table if not exists servicii(
    id_serviciu int NOT NULL auto_increment primary key,
    id_client int NOT NULL,
    denumire_serviciu varchar(255) NOT NULL,
    detalii varchar(255),
    foreign key (id_client) references clienti (id_client)
    );



create table if not exists asignari(
    id_asignare int NOT NULL auto_increment primary key,
    id_serviciu int NOT NULL,
    id_angajat int NOT NULL,
    foreign key (id_serviciu) references servicii (id_serviciu),
    foreign key (id_angajat) references angajati (id_angajat) 
    );


create table if not exists istoric(
    id_istoric int NOT NULL auto_increment primary key,
    id_serviciu int NOT NULL UNIQUE,
    denumire_serviciu varchar(255) NOT NULL,
    nume_client varchar(255) NOT NULL,
    data_incepere date,
    data_inchere date,
    pret float,
    detalii varchar(255)
    );