SET sql_mode = '';

SET foreign_key_checks = 0;
	
drop table `user`;
drop table `events`;
drop table `category`;
drop table `venues`;
drop table `admin`;
drop table `reservations`;
drop table `play`;
drop table `labels`;
drop table `labeled`;

SET foreign_key_checks = 1;

CREATE TABLE `user` (
  `id` int not null PRIMARY KEY AUTO_INCREMENT,
  `fname` varchar(255),
  `lname` varchar(255),
  `username` varchar(255) not null,
  `password` varchar(255) not null,
  `interests` varchar(255),
  `email` varchar(255),
  `address` varchar(255),
  `created_at` timestamp,
  `last_login` timestamp
);

CREATE TABLE `events` (
  `id` int not null PRIMARY KEY AUTO_INCREMENT,
  `title` varchar(255),
  `category_id` int,
  `created_at` timestamp,
  `description` text,
  `participants_amount` int,
  `admin_id` int,
  `json_id` varchar(255)
);

CREATE TABLE `category` (
  `id` int not null PRIMARY KEY AUTO_INCREMENT,
  `name` varchar(255)
);

CREATE TABLE `venues` (
  `id` int not null PRIMARY KEY AUTO_INCREMENT,
  `name` varchar(255),
  `location` varchar(255),
  `capacity` int,
  `json_id` varchar(255)
);

CREATE TABLE `admin` (
  `id` int not null PRIMARY KEY AUTO_INCREMENT,
  `fname` varchar(255),
  `lname` varchar(255),
  `username` varchar(255),
  `password` varchar(255),
  `iban` varchar(255),
  `email` varchar(255),
  `address` varchar(255)
);

CREATE TABLE `reservations` (
  `id` int not null PRIMARY KEY AUTO_INCREMENT,
  `user_id` int,
  `event_id` int,
  `bool` bool,
  `payment_type` varchar(255)
);

CREATE TABLE `play` (
  `event_id` int,
  `venue_id` int,
  `date` timestamp,
  primary key (`event_id`, `date`)
);

CREATE TABLE `labels`(
`id` int not null primary key auto_increment,
`name` varchar(255)
);

CREATE TABLE `labeled`(
`event_id` int,
`label_id` int,
primary key (`event_id`,`label_id`)
);

ALTER TABLE `events` ADD FOREIGN KEY (`admin_id`) REFERENCES `admin` (`id`);

ALTER TABLE `reservations` ADD FOREIGN KEY (`user_id`) REFERENCES `user` (`id`);

ALTER TABLE `reservations` ADD FOREIGN KEY (`event_id`) REFERENCES `events` (`id`);

ALTER TABLE `events` ADD FOREIGN KEY (`category_id`) REFERENCES `category` (`id`);

ALTER TABLE `play` ADD FOREIGN KEY (`event_id`) REFERENCES `events` (`id`);

ALTER TABLE `play` ADD FOREIGN KEY (`venue_id`) REFERENCES `venues` (`id`);

ALTER TABLE `category` ADD column father int after name;

ALTER TABLE `labeled` ADD FOREIGN KEY (`event_id`) REFERENCES `events` (`id`);

ALTER TABLE `labeled` ADD FOREIGN KEY (`label_id`) REFERENCES `labels` (`id`);

insert into category(name,father) values ('Music',null);
insert into category(name,father) values ('Theater',null);
insert into category(name,father) values ('Conference',null);
insert into category(name,father) values ('Festivals',null);
insert into category(name,father) values ('Sports',null);
insert into category(name,father) values ('Educational',3);
insert into category(name,father) values ('Informing',3);
insert into category(name,father) values ('Football',5);
insert into category(name,father) values ('Basketball',5);

insert into labels(name) values ('basketball');
insert into labels(name) values ('soccer');
insert into labels(name) values ('technology');
insert into labels(name) values ('sience');
insert into labels(name) values ('business');
insert into labels(name) values ('music');
insert into labels(name) values ('health');
insert into labels(name) values ('medical');
insert into labels(name) values ('sport');