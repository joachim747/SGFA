Feature: Move

   Move the player by pressing button

   Scenario: Walk Forward
    Given Testscene is loaded
    Given Rotation is 0
    Given Player (1|2) Position is "(.*?)" x  "(.*?)" y  "(.*?)" z
    When I press Forward (1|2)
    Then Position Player (1|2) should be "(.*?)" + 1 x  "(.*?)" y "(.*?)" z

   Scenario: Walk Backwards
    Given Testscene is loaded
    Given Rotation is 0
    Given Player (1|2) Position is 0x 0y 0z
    When I press Backwards (1|2)
    Then Position Player (1|2) should be -1x 0y 0z

   Scenario: Rotate Right
    Given Testscene is loaded
    Given Player (1|2) Rotation "(.*?)"
    When I press Right (1|2)
    Then Rotation Player (1|2) should be "(.*?)" + 1

   Scenario: Rotate Left
    Given Testscene is loaded
    Given Player (1|2) Rotation "(.*?)"
    When I press Left (1|2)
    Then Rotation Player (1|2) should be "(.*?)" -1

   Scenario: Simoultaneous Movement
    Given Testscene is loaded
    Given Forward1 is pressed
    When I press Forward2
    Then Player2 should Move
    And Player1 should still move simoultaneous