// This is a library import. The name of the import here 
// corresponds with the name of the path in main.ts.
import * as $ from "jquery";

// This is a custom script import.
import { Logger } from "../Logger"; 


class IndexViewModel {
    constructor() {
        Logger.Log("This is from a viewmodel.");
        $(".display-4").html("Welcome by JQuery");
    }
}

export let ViewModel = new IndexViewModel();
