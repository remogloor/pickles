﻿Feature: Formatting A Feature

@cucumber
Scenario: A simple feature

    Given I have this feature description
        """
        Feature: Clearing Screen
            In order to restart a new set of calculations
            As a math idiot
            I want to be able to clear the screen

        @workflow @slow
        Scenario: Clear the screen
            Clear the screen by pressing C
            Given I have entered 50 into the calculator
            And I have entered 70 into the calculator
            When I press C
            Then the screen should be empty
        """
    When I generate the documentation
    Then the JSON file should contain
"""
[
  {
    "id": "clearing-screen",
    "keyword": "Feature",
    "name": "Clearing Screen",
    "description": "In order to restart a new set of calculations\r\nAs a math idiot\r\nI want to be able to clear the screen",
    "tags": [],
    "line": 1,
    "elements": [
      {
        "id": "clearing-screen;clear-the-screen",
        "keyword": "Scenario",
        "name": "Clear the screen",
        "description": "Clear the screen by pressing C",
        "line": 7,
        "type": "scenario",
        "tags": [
          {
            "name": "@workflow"
          },
          {
            "name": "@slow"
          }
        ],
        "steps": [
          {
            "keyword": "Given",
            "name": "I have entered 50 into the calculator",
            "line": 9,
            "hidden": false,
            "result": {
              "status": "undefined",
              "duration": 1
            }
          },
          {
            "keyword": "And",
            "name": "I have entered 70 into the calculator",
            "line": 10,
            "hidden": false,
            "result": {
              "status": "undefined",
              "duration": 1
            }
          },
          {
            "keyword": "When",
            "name": "I press C",
            "line": 11,
            "hidden": false,
            "result": {
              "status": "undefined",
              "duration": 1
            }
          },
          {
            "keyword": "Then",
            "name": "the screen should be empty",
            "line": 12,
            "hidden": false,
            "result": {
              "status": "undefined",
              "duration": 1
            }
          }
"""

@cucumber
Scenario: A feature with a table

    Given I have this feature description
        """
        Feature: Interactive DHTML View
            In order to increase stakeholder engagement with pickled specs
            As a SpecFlow evangelist
            I want to adjust the level of detail in the DHTML view to suit my audience
            So that I do not overwhelm them.

        Scenario: Scenario with large data table
            Given a feature with a large table of data:
                | heading    | page # |
                | Chapter 1  | 1      |
                | Chapter 2  | 5      |
                | Chapter 3  | 10     |
                | Chapter 4  | 15     |
                | Chapter 5  | 20     |
                | Chapter 6  | 25     |
                | Chapter 7  | 30     |
                | Chapter 8  | 35     |
                | Chapter 9  | 40     |
                | Chapter 10 | 45     |
                | Chapter 11 | 50     |
                | Chapter 12 | 55     |
                | Chapter 13 | 60     |
                | Chapter 14 | 65     |
                | Chapter 15 | 70     |
                | Chapter 16 | 75     |
                | Chapter 17 | 80     |
                | Chapter 18 | 85     |
                | Chapter 19 | 90     |
                | Chapter 20 | 95     |
                | Chapter 21 | 100    |
                | Chapter 22 | 105    |
            When I click on the table heading
            Then the table body should collapse
        """
    When I generate the documentation
    Then the JSON file should contain
"""
[
  {
    "id": "interactive-dhtml-view",
    "keyword": "Feature",
    "name": "Interactive DHTML View",
    "description": "In order to increase stakeholder engagement with pickled specs\r\nAs a SpecFlow evangelist\r\nI want to adjust the level of detail in the DHTML view to suit my audience\r\nSo that I do not overwhelm them.",
    "tags": [],
    "line": 1,
    "elements": [
      {
        "id": "interactive-dhtml-view;scenario-with-large-data-table",
        "keyword": "Scenario",
        "name": "Scenario with large data table",
        "description": "",
        "line": 7,
        "type": "scenario",
        "tags": [],
        "steps": [
          {
            "keyword": "Given",
            "name": "a feature with a large table of data:",
            "line": 8,
            "hidden": false,
            "result": {
              "status": "undefined",
              "duration": 1
            }
          },
          {
            "keyword": "When",
            "name": "I click on the table heading",
            "line": 32,
            "hidden": false,
            "result": {
              "status": "undefined",
              "duration": 1
            }
          },
          {
            "keyword": "Then",
            "name": "the table body should collapse",
            "line": 33,
            "hidden": false,
            "result": {
              "status": "undefined",
              "duration": 1
            }
          }
"""

