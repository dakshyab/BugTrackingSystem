-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 23, 2018 at 06:19 PM
-- Server version: 5.6.20
-- PHP Version: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `bug_tracking_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_buglog`
--

CREATE TABLE IF NOT EXISTS `tbl_buglog` (
`order_id` int(11) NOT NULL,
  `project_name` varchar(20) NOT NULL,
  `bug` varchar(20) NOT NULL,
  `updated_by` varchar(50) NOT NULL,
  `updated_on` varchar(50) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `tbl_buglog`
--

INSERT INTO `tbl_buglog` (`order_id`, `project_name`, `bug`, `updated_by`, `updated_on`) VALUES
(8, 'calculator', 'new', 'harry', '11/23/2018 05:56 PM'),
(9, 'calculator', 'new', 'harry', '11/23/2018 05:56 PM'),
(10, 'EMS', 'tri', 'Sally', '11/23/2018 05:56 PM'),
(11, 'EMS', 'tri', 'Sally', '11/23/2018 05:56 PM');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_bugs`
--

CREATE TABLE IF NOT EXISTS `tbl_bugs` (
`bug_id` int(11) NOT NULL,
  `project_name` varchar(50) NOT NULL,
  `bug` varchar(50) NOT NULL,
  `bug_desc` varchar(50) NOT NULL,
  `screenshot` varchar(250) NOT NULL,
  `code` varchar(1000) NOT NULL,
  `date_discovered` varchar(50) NOT NULL,
  `verified_status` varchar(20) NOT NULL,
  `date_verified` varchar(50) NOT NULL,
  `solution` varchar(1000) NOT NULL,
  `updated_by` varchar(500) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Dumping data for table `tbl_bugs`
--

INSERT INTO `tbl_bugs` (`bug_id`, `project_name`, `bug`, `bug_desc`, `screenshot`, `code`, `date_discovered`, `verified_status`, `date_verified`, `solution`, `updated_by`) VALUES
(15, 'EMS', 'database error', 'MySQL database connection is not defined in the pr', 'database.PNG', 'public class databaseConnector\n    {\n        private MySqlConnection connection;\n        private string server;\n        private string database;\n        private string uid;\n        private string password;\n\n        public MySqlConnection Db_Connect()\n        {\n            server = "localhost";\n            database = "employee_mgmt_system";\n            uid = "root";\n            password = "";\n            string connectionstring;\n            connectionstring = "SERVER=" + server + ";" + "DATABASE=" +\n            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";\n\n            connection = new MySqlConnection(connectionstring);\n            connection.Open();\n            \n            return connection;\n        }\n\n        public void CloseConnection()\n        {\n            connection.Close();\n        }\n\n    }   ', '05/08/2018', 'No', '', '', ''),
(16, 'calculator', 'datatype error', 'The datatype defined for area is not correct.\nMeth', 'maths_flat.PNG', 'if (side_a.Text == "" || side_b.Text == "" || side_c.Text == "")\n                {\n                    MessageBox.Show("The values of a, b or c cannot be empty!!");\n                }\n                else\n                {\n                    Single val_a;\n                    val_a = Convert.ToSingle(side_a.Text);\n                    val_a = Single.Parse(side_a.Text);\n\n                    Single val_b;\n                    val_b = Convert.ToSingle(side_b.Text);\n                    val_b = Single.Parse(side_b.Text);\n\n                    Single val_c;\n                    val_c = Convert.ToSingle(side_c.Text);\n                    val_c = Single.Parse(side_c.Text);\n\n                    Single s;\n                    s = (val_a + val_b + val_c) / 2;\n\n                    int area;\n                    area = (s * (s - val_a) * (s - val_b) * (s - val_c));\n\n                    Single calc_area;\n                    calc_area = Convert.ToSingle(Math.Sqrt(area));\n\n                    label_ans.Text =', '05/08/2018', 'No', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_users`
--

CREATE TABLE IF NOT EXISTS `tbl_users` (
`user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `position` varchar(20) NOT NULL,
  `verified` varchar(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `tbl_users`
--

INSERT INTO `tbl_users` (`user_id`, `username`, `password`, `position`, `verified`) VALUES
(1, 'daks', '1234', 'Admin', 'yes'),
(3, 'Sally', 'qwerty', 'Developer', 'yes'),
(4, 'crunchy', 'crab', 'Tester', 'yes'),
(5, 'harry', 'abcd', 'Developer', 'yes'),
(7, 'niraj', 'nunnu', 'Tester', 'yes'),
(9, 'hari', '1234', '', 'no'),
(10, 'Nate', 'nora123', 'Tester', 'no');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_buglog`
--
ALTER TABLE `tbl_buglog`
 ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `tbl_bugs`
--
ALTER TABLE `tbl_bugs`
 ADD PRIMARY KEY (`bug_id`), ADD UNIQUE KEY `project_id` (`bug_id`);

--
-- Indexes for table `tbl_users`
--
ALTER TABLE `tbl_users`
 ADD PRIMARY KEY (`user_id`), ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_buglog`
--
ALTER TABLE `tbl_buglog`
MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `tbl_bugs`
--
ALTER TABLE `tbl_bugs`
MODIFY `bug_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT for table `tbl_users`
--
ALTER TABLE `tbl_users`
MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
