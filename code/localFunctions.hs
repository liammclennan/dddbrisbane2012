import Data.List

-- this function uses higher order functions, composition and a local function 
countJsFiles = length . filter isJsFile
    where isJsFile = isSuffixOf ".js"

