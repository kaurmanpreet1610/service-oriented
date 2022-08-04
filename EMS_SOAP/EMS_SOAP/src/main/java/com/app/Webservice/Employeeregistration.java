package com.app.Webservice;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Employeeregistration {
	
	// Database data
    String driverName = "com.mysql.cj.jdbc.Driver";
    String serverName = "localhost:3306"; 
    String schema = "ems";
    String url = "jdbc:mysql://" + serverName +  "/" + schema;
    String un = "root";
    String pass = "";
    Connection connection = null;
	
	
	public int login(String username, String password)
	{ 
        // strings to collect username and password from USERS table 
        String strUN = "";
        String strPASS = "";
        int userID = 0;
        
        try {
			Class.forName(driverName);
			connection = DriverManager.getConnection(url, un, pass);
			Statement statement = connection.createStatement();
			ResultSet results = statement.executeQuery("SELECT * FROM employees WHERE username = '" + username + "' ORDER BY username" );
			
			while (results.next()) {			
				  strUN = results.getString("username");				 
				  strPASS = results.getString("password");
				  userID = results.getInt("id");
				}
			
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

        if (username.equals(strUN) && password.equals(strPASS)){
        	return userID;
        }
        else
        {
        	return -1;
        }
	}
	
	public int loginAdmin(String username, String password)
	{ 
        // strings to collect username and password from USERS table 
        String strUN = "";
        String strPASS = "";
        int userID = 0;
        
        try {
			Class.forName(driverName);
			connection = DriverManager.getConnection(url, un, pass);
			Statement statement = connection.createStatement();
			ResultSet results = statement.executeQuery("SELECT * FROM admins WHERE username = '" + username + "' ORDER BY username" );
			
			while (results.next()) {			
				  strUN = results.getString("username");				 
				  strPASS = results.getString("password");
				  userID = results.getInt("id");
				}
			
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

        if (username.equals(strUN) && password.equals(strPASS)){
        	return userID;
        }
        else
        {
        	return -1;
        }
	}
	
	public int register(String username, String password)
	{ 
        // strings to collect username and password from USERS table 
        String strUN = "";
        String strPASS = "";
        int userID = 0;
        
        try {
			Class.forName(driverName);
			connection = DriverManager.getConnection(url, un, pass);
			Statement statement = connection.createStatement();
			String query = " insert into employees (username, password) values (?, ?)";
			PreparedStatement preparedStmt = connection.prepareStatement(query);
			preparedStmt.setString (1, username);
		    preparedStmt.setString (2, password);
		    preparedStmt.execute();
		    connection.close();
		    return 1;
			
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
        return -1;
	}
	
	public int edit(int id, String username, String password)
	{ 
        // strings to collect username and password from USERS table 
        String strUN = "";
        String strPASS = "";
        int userID = 0;
        int updNo = -1;
        
        try {
			Class.forName(driverName);
			connection = DriverManager.getConnection(url, un, pass);
			Statement statement = connection.createStatement();
			updNo = statement.executeUpdate("UPDATE employees SET username = '" + username + "', password = '" + password + "' WHERE id = " + id);
			
			
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
        return updNo;
	}
	
	public void delete(int id)
	{ 
        // strings to collect username and password from USERS table 
        String strUN = "";
        String strPASS = "";
        int userID = 0;
        
        try {
			Class.forName(driverName);
			connection = DriverManager.getConnection(url, un, pass);
			Statement statement = connection.createStatement();
			int updNo = statement.executeUpdate("DELETE FROM employees WHERE id = " + id);
			
			
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
