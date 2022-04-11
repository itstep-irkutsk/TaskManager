INSERT INTO host1323541_taskmanager.tbl_status_task (status)
VALUES ('created');

INSERT INTO host1323541_taskmanager.tbl_tasks (title, content, date_of_creation, date_of_start, date_of_end, deadline, status_id)
VALUES ('Task 1', 'content 1', '2022-01-01 16:00:33', '2022-04-11 16:00:46', null, null, 1);


INSERT INTO host1323541_taskmanager.tbl_stages (description, date_of_creation, task_id)
VALUES ('description 1', '2022-04-11 15:57:18', 1),
       ('description 2', '2022-01-11 15:57:47', 1);