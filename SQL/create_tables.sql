CREATE TABLE tbl_status_task
(
    id     INT          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    status VARCHAR(100) NOT NULL
);

CREATE TABLE tbl_tasks
(
    id               INT           NOT NULL PRIMARY KEY AUTO_INCREMENT,
    title            NVARCHAR(255) NOT NULL,
    content          TEXT,
    date_of_creation DATETIME      NOT NULL,
    date_of_start    DATETIME,
    date_of_end      DATETIME,
    deadline         DATETIME,
    status_id        INT           NOT NULL,
    FOREIGN KEY (status_id) REFERENCES tbl_status_task (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);

CREATE TABLE tbl_stages
(
    id               INT      NOT NULL PRIMARY KEY AUTO_INCREMENT,
    description      TEXT,
    date_of_creation DATETIME NOT NULL,
    task_id          INT      NOT NULL,
    FOREIGN KEY (task_id) REFERENCES tbl_tasks (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);

CREATE TABLE tbl_type_messenger
(
    id   INT          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    type VARCHAR(100) NOT NULL
);

CREATE TABLE tbl_users
(
    id          INT          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    login       VARCHAR(125) NOT NULL,
    password    VARCHAR(125) NOT NULL,
    first_name  VARCHAR(125) NOT NULL,
    last_name   VARCHAR(125) NOT NULL,
    middle_name VARCHAR(125) NOT NULL
);

CREATE TABLE tbl_user_messengers
(
    id      INT          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    user_id INT          NOT NULL,
    type_id INT          NOT NULL,
    link    VARCHAR(255) NOT NULL,
    FOREIGN KEY (user_id) REFERENCES tbl_users (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    FOREIGN KEY (type_id) REFERENCES tbl_type_messenger (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);

CREATE TABLE tbl_task_users
(
    id      INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    task_id INT NOT NULL,
    user_id INT NOT NULL,
    FOREIGN KEY (task_id) REFERENCES tbl_tasks (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    FOREIGN KEY (user_id) REFERENCES tbl_users (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);

CREATE VIEW vw_tasks AS
    SELECT tbl_tasks.id AS id,
           title,
           content,
           date_of_creation,
           date_of_start,
           date_of_end,
           deadline,
           status
    FROM tbl_tasks
    JOIN tbl_status_task 
        ON tbl_tasks.status_id = tbl_status_task.id;