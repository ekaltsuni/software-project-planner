﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePlanner
{
    internal class SQLConstants
    {
        // GENERAL
        public static readonly string CONNECTION_STRING = "Data source=app-data.db;Version=3";
        public static readonly string RETURN_USER = "SELECT id FROM User WHERE username = @username AND password = @password";
        public static readonly string RETURN_ROLE = "SELECT role FROM User WHERE id = @id";

        public static readonly string RETURN_USER_VARIABLES = @"SELECT email, username, password, name, surname 
                                                                FROM User 
                                                                WHERE id = @id";
        public static readonly string UPDATE_USER_VARIABLES = @"UPDATE OR IGNORE User SET 
                                                                    username = @username, password = @password, 
                                                                    email = @email, name = @name, 
                                                                    surname = @surname, gender = @gender
                                                               WHERE id = @id";
        public static readonly string CREATE_USER_VARIABLES = @"INSERT OR IGNORE INTO User 
                                                                (username, password, email, role, name, surname, gender, signing_date) VALUES 
                                                                (@username, @password, @email, @role, @name, @surname, @gender, @signing_date)";
        public static readonly string RETURN_LATEST_USER_ID = "SELECT id FROM User ORDER BY id DESC LIMIT 1";
        public static readonly string RETURN_LATEST_PROJECT_ID = "SELECT project_id FROM Project ORDER BY project_id DESC LIMIT 1";
        // DEVELOPER
        //public static readonly string CREATE_DEVELOPER_VARIABLES = "INSERT OR IGNORE INTO Developer (skills, cv, portfolio_links, id) " +
        //"VALUES (?, ?, ?, @id)";
        //public static readonly string RETURN_DEVELOPER_VARIABLES = "SELECT skills, cv, portfolio_links FROM Developer" +
        //  " WHERE id = @id";
        public static readonly string RETURN_SKILLS = "SELECT * FROM Skills WHERE id = @id";
        public static readonly string CREATE_SKILLS = @"INSERT OR IGNORE INTO Skills 
                                                        (c, css, html, java, javascript, php, python, ruby, other, id) VALUES 
                                                        (@c, @css, @html, @java, @javascript, @php, @python, @ruby, @other, @id)";
        public static readonly string UPDATE_SKILLS = @"UPDATE Skills SET 
                                                            c = @c, css = @css, html = @html, java = @java, 
                                                            javascript = @javascript, php = @php, python = @python, ruby = @ruby, 
                                                            other = @other 
                                                        WHERE id = @id";
        public static readonly string UPDATE_DEVELOPER_VARIABLES = @"UPDATE OR IGNORE Developer SET
                                                                        skills = @skills, cv = @cv, portfolio_links = @portfolio_links
                                                                     WHERE id = @id";
        public static readonly string RETURN_DEV_SIMPLE = @"SELECT u.username
                                                            FROM User u
                                                            INNER JOIN Developer d
                                                                ON u.id = d.id
                                                            WHERE u.username LIKE @username";
        public static readonly string RETURN_DEV_ADVANCED = @"SELECT u.username
                                                              FROM User u
                                                              INNER JOIN Developer d
                                                                ON u.id = d.id
                                                              WHERE u.username LIKE @username
                                                                AND u.signing_date >= @dateBefore AND u.signing_date <= @dateAfter
                                                                AND d.rating BETWEEN @minRating AND @maxRating
                                                                AND d.project_count BETWEEN @minCount AND @maxCount";
        // CLIENT
        public static readonly string CREATE_CLIENT_VARIABLES = @"INSERT OR IGNORE INTO Client 
                                                                  (id, date_of_birth, description, link)
                                                                  VALUES (@id, @date_of_birth, @description, @link)";
        public static readonly string RETURN_CLIENT_VARIABLES = @"SELECT date_of_birth, link, description 
                                                                  FROM Client
                                                                  WHERE id = @id";
        public static readonly string UPDATE_CLIENT_VARIABLES = @"UPDATE OR IGNORE Client SET
                                                                  date_of_birth = @date_of_birth, link = @link, description = @description
                                                                  WHERE id = @id";
        public static readonly string RETURN_CLIENT_SIMPLE = @"SELECT u.username
                                                                FROM User u
                                                                INNER JOIN Client c
                                                                    ON u.id = c.id
                                                                WHERE u.username LIKE @username
                                                                    OR c.description LIKE @username";
        public static readonly string RETURN_CLIENT_ADVANCED = @"SELECT u.username
                                                                FROM User u
                                                                INNER JOIN Client c
                                                                    ON u.id = c.id
                                                                WHERE (u.username LIKE @username
                                                                    OR c.description LIKE @username)
                                                                    AND u.signing_date >= @dateBefore AND u.signing_date <= @dateAfter";
        // PROJECT
        public static readonly string RETURN_PROJECT_SIMPLE = @"SELECT title
                                                                FROM Project p
                                                                WHERE p.title LIKE @title
                                                                    OR p.description LIKE @title";
        public static readonly string RETURN_PROJECT_ADVANCED = @"SELECT title
                                                                FROM Project p
                                                                INNER JOIN ProjectCategory pc
                                                                    ON pc.project_id = p.id
                                                                INNER JOIN ProjectTechnology pt
                                                                    ON pt.project_id = p.id
                                                                WHERE (p.title LIKE @title
                                                                    OR p.description LIKE @title)
                                                                    AND pc.category LIKE @category AND pc.subcategory LIKE @subcategory
                                                                    AND p.date >= @dateBefore AND p.date <= @dateAfter
                                                                    AND pt.category IN @technologies";
        public static readonly string SAVE_PROJECT = 
            @"INSERT INTO Project 
             (title, description, type, price_visibility, category, subcategory, payment, max_price, duration, bidding_duration) VALUES
             (@title, @description, @type, @price_visibility, @category, @subcategory, @payment, @max_price, @duration, @bidding_duration)";
        public static readonly string UPDATE_PROJECT_TECHNOLOGY = @"INSERT INTO ProjectTechnology (project_id, technology_id) VALUES
                                                                    (@project_id, @technology_id)";
        // DROPDOWNS
        public static readonly string RETURN_PROJECT_TYPES = "SELECT type FROM ProjectType";
        public static readonly string RETURN_ID_BY_PROJECT_TYPE = "SELECT id FROM ProjectType WHERE type = @type";
        public static readonly string RETURN_PROJECT_CATEGORIES = "SELECT name FROM ProjectCategory";
        public static readonly string RETURN_ID_BY_PROJECT_CATEGORY = "SELECT id FROM ProjectCategory WHERE name = @name";
        public static readonly string RETURN_PROJECT_PAYMENT = "SELECT type FROM ProjectPayment";
        public static readonly string RETURN_ID_BY_PROJECT_PAYMENT = "SELECT id FROM ProjectPayment WHERE type = @type";
        public static readonly string RETURN_PROJECT_DURATION = "SELECT type FROM ProjectDuration";
        public static readonly string RETURN_ID_BY_PROJECT_DURATION = "SELECT id FROM ProjectDuration WHERE type = @type";
        public static readonly string RETURN_SUBCATEGORIES_BY_CATEGORY = @"SELECT ps.name
                                                                           FROM ProjectSubCategory ps
                                                                           INNER JOIN ProjectCategory pc
                                                                                ON pc.id = ps.category_id
                                                                           WHERE pc.name = @categoryName";
        public static readonly string RETURN_ID_BY_PROJECT_SUBCATEGORY = "SELECT id FROM ProjectSubCategory WHERE name = @name";
        public static readonly string UPDATE_TECHNOLOGY = "INSERT OR IGNORE INTO Technology (description) VALUES (@description)";      
        public static readonly string RETURN_ID_BY_TECHNOLOGY = "SELECT id FROM Technology WHERE description = @description";


        // UPDATE FIELDS VISIBILITY TO-DO
    }
}
