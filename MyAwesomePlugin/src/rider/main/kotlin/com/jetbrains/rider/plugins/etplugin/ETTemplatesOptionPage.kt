package com.jetbrains.rider.plugins.etplugin

import com.intellij.openapi.options.Configurable
import com.intellij.openapi.util.NlsSafe
import com.jetbrains.rider.settings.simple.SimpleOptionsPage

class ETFileTemplatesOptionPage: SimpleOptionsPage(pageName, "RiderETFileTemplatesSettings"), Configurable.NoScroll {
    companion object {
        @NlsSafe
        const val pageName = "ET"
    }

    override fun getId(): String {
        return "RiderETFileTemplatesSettings"
    }
}

class ETLiveTemplatesOptionPage: SimpleOptionsPage(pageName, "RiderETLiveTemplatesSettings"), Configurable.NoScroll {
    companion object {
        @NlsSafe
        const val pageName = "ET"
    }

    override fun getId(): String {
        return "RiderETLiveTemplatesSettings"
    }
}