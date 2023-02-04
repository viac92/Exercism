module LogLevels
open System.Text.RegularExpressions


let message (logLine: string): string = 
    let indexOfSemi = logLine.IndexOf(":")
    let s = logLine.Substring(indexOfSemi + 2)
    Regex.Replace(s, @"\t|\n|\r", "").Trim(' ')

let logLevel(logLine: string): string = 
    let IndexOfSemi = logLine.IndexOf(":")
    logLine.Remove(IndexOfSemi).Trim('[', ']').ToLower()

let reformat(logLine: string): string =
    message(logLine) + " (" + logLevel(logLine) + ")"