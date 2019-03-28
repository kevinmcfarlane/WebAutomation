namespace MyApp

open canopy.runner.classic
open canopy.configuration
open canopy.classic
open System

module Source =
    open canopy.types

    /// <summary>
    /// Performs JobServe search for the specified skill(s).
    /// </summary>
    /// <param name="skill">The skill, e.g., "c#", "machine learning."</param>
    let jobServe skill = 

        autoPinBrowserRightOnLaunch <- false
        start firefox

        "Run JobServe Search" &&& fun _ ->
            let quote = "\""
            let contract = "2"
            let location = ""
            let today = "0"
            let jobType = contract
            let classicView = "#searchtogglelink"
            // Ensure that the JobServe search is entered in quotes, e.g., that the search box receives "machine learning" not machine learning, 
            // otherwise we'd get results for 'machine learning' as well as 'machine' and 'learning.'
            let quotedSkill = quote + skill + quote

            url "https://www.jobserve.com/"
            "#txtKey" << quotedSkill
            "#txtLoc" << location
            "#selAge" << today
            "#selJType" << jobType
            click "#btnSearch"
            click classicView

        run()

        printfn "press [enter] to exit"
        Console.ReadLine() |> ignore

        quit()

    /// <summary>
    /// Performs JobServe perm job search for the specified skill(s).
    /// </summary>
    /// <param name="skill">The skill, e.g., "c#", "machine learning."</param>
    let jobServePerm skill = 

        autoPinBrowserRightOnLaunch <- false
        start firefox

        "Run JobServe Search" &&& fun _ ->
            let powerSearch = "#lab2"
            let quote = "\""
            let perm = "1"
            let location = "Oxford"
            let withinDays = "1"
            let jobType = perm
            let miles = "25" 
            let salary = "#ddcl-selSalary"
            let salary50to75k = "#ddcl-selSalary-i6"
            let classicView = "#searchtogglelink"
            // Ensure that the JobServe search is entered in quotes, e.g., that the search box receives "machine learning" not machine learning, 
            // otherwise we'd get results for 'machine learning' as well as 'machine' and 'learning.'
            let quotedSkill = quote + skill + quote

            url "https://www.jobserve.com/"
            click powerSearch
            "#txtKey" << quotedSkill
            "#txtLoc" << location
            "#selAge" << withinDays
            "#selJType" << jobType
            "#selRad" << miles
            click salary
            click salary50to75k
            click "#btnSearch"
            click classicView

        run()

        printfn "press [enter] to exit"
        Console.ReadLine() |> ignore

        quit()

    /// <summary>
    /// Displays job stats at ITJobsWatch for the specified skill(s).
    /// </summary>
    /// <param name="skill">The skill, e.g., "c#", "machine learning."</param>
    let itjobswatch skill = 

        start firefox
        pin direction.FullScreen

        "display itjobswatch" &&& fun _ ->

            url "https://www.itjobswatch.co.uk/"
            click "#ctl00_tabContract"
            "#search" << skill
            press enter
            click skill

        run()

        printfn "press [enter] to exit"
        Console.ReadLine() |> ignore

        quit()

