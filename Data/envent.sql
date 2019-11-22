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
  `category` int,
  `date` timestamp,
  `description` text,
  `venue` text,
  `participants_amount` int,
  `created_at` timestamp,
  `admin_id` int
);

CREATE TABLE `category` (
  `id` int not null PRIMARY KEY AUTO_INCREMENT,
  `name` varchar(255)
);

CREATE TABLE `venues` (
  `id` int not null PRIMARY KEY AUTO_INCREMENT,
  `event_id` int,
  `name` varchar(255),
  `location` varchar(255),
  `capacity` int
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

ALTER TABLE `events` ADD FOREIGN KEY (`admin_id`) REFERENCES `admin` (`id`);

ALTER TABLE `venues` ADD FOREIGN KEY (`event_id`) REFERENCES `events` (`id`);

ALTER TABLE `reservations` ADD FOREIGN KEY (`user_id`) REFERENCES `user` (`id`);

ALTER TABLE `reservations` ADD FOREIGN KEY (`event_id`) REFERENCES `events` (`id`);

ALTER TABLE `category` ADD FOREIGN KEY (`category_id`) REFERENCES `category` (`id`);