Write-Host "Welcome to tests"

Write-Host [1, 2, 3].select { |e| e > 2 }.size
Write-Host [1, 2, 3].reject { |e| e < 2 }.size
Write-Host [1, 2, 3].select(&.< 2).size
Write-Host [0, 1, 2].select(&.zero?).size
Write-Host [0, 1, 2].reject(&.zero?).size

[-1, 0, 1, 2].select { |e| e > 0 }.first?
[-1, 0, 1, 2].select { |e| e > 0 }.last?