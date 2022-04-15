Feature: Inbox

    Any newly added task should be automatically added to the inbox.

    Scenario Outline: New task is added to the inbox
        Given There is <initialTaskCount> item in the inbox
        When I add a task
        Then There is <totalTaskCount> item in the inbox

        Examples:
            | initialTaskCount | totalTaskCount |
            | 0                | 1              |
            | 1                | 2              |
            | 100              | 101            |

    Scenario: Add due date to task remove from inbox
        Given There is 1 item in the inbox
        When I add a task with due date
        Then There is 0 item in the inbox
        And The task has a due date