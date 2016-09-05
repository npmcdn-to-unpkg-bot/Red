Feature:

  Scenario: I can ping the service
    When I GET /private/ping
    Then response code should be 200
