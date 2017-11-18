Feature: Start Game

   Start the game using the MainMenu

   Scenario: Start Campaign
    When I click on the campaign button within the MainMenu 
    Then first level should be loaded

   Scenario: Select Level
    When I click on the select-level button within MainMenu
    And I select a level "(.*?)" in the submenu
    Then selected level "(.*?)" should be loaded