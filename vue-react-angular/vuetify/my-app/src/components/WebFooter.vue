<template>
    <v-footer
        dark
        height="auto"
        padless
        fixed>
        <v-card
            class="flex green darken-4"
            flat
            tile>
            <v-card-title class="green darken-4">
                <strong class="subheading"> Get connected with us on social networks!</strong>

                <v-spacer></v-spacer>

                <v-btn
                    v-for="icon in icons"
                    :key="icon"
                    class="mx-3"
                    dark
                    icon>
                        <v-icon size="24px">{{ icon }}</v-icon>
                </v-btn>
            </v-card-title>
            <div class="grey darken-3">
                <v-card-actions id="vca">
                &copy;  {{ new Date().getFullYear() }} — <strong> Universitas Riau</strong>
            </v-card-actions>
            </div>
        </v-card>
    </v-footer>
</template>

<script>
    export default {
        data: () => ({
            icons: [
                'mdi-facebook',
                'mdi-twitter',
                'mdi-google-plus',
                'mdi-linkedin',
                'mdi-instagran'
            ]
        })
    }
</script>

<style>
#vca {
    justify-content: center
}
</style>