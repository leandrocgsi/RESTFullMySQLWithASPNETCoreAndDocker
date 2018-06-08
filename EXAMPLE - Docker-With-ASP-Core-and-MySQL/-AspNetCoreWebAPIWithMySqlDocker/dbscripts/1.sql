CREATE DATABASE conferenceapp;

USE conferenceapp;

CREATE TABLE conference_session (
	id_session  int NOT NULL AUTO_INCREMENT,
	name varchar(255),
	location varchar(255),
	description varchar(9999),
	time_start datetime,
	time_end datetime,
	PRIMARY KEY (id_session)
);

INSERT INTO `conferenceapp`.`conference_session` (`name`, `location`, `description`) 
	VALUES ('session 1', 'Berlin', 'Session 1 will be awesome!');
	
INSERT INTO `conferenceapp`.`conference_session` (`name`, `location`, `description`) 
	VALUES ('session 2', 'Berlin', 'Session 2 will be great!');