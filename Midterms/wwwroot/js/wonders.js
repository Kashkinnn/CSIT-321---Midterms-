window.wondersScroll = {
    _handler: null,

    init: function (dotNetRef, sectionId, count) {
        const section = document.getElementById(sectionId);
        if (!section) return;
        let last = -1;

        this._handler = function () {
            const rect = section.getBoundingClientRect();
            const total = section.offsetHeight - window.innerHeight;
            const p = Math.min(Math.max(-rect.top / total, 0), 0.9999);
            const idx = Math.floor(p * count);
            if (idx !== last) {
                last = idx;
                dotNetRef.invokeMethodAsync("OnScrollIndex", idx);
            }
        };

        window.addEventListener("scroll", this._handler, { passive: true });
        this._handler();
    },

    scrollTo: function (sectionId, count, index) {
        const section = document.getElementById(sectionId);
        if (!section) return;
        const total = section.offsetHeight - window.innerHeight;
        const top = section.offsetTop + ((index + 0.5) / count) * total;
        window.scrollTo({ top: top, behavior: "smooth" });
    },

    dispose: function () {
        if (this._handler) window.removeEventListener("scroll", this._handler);
        this._handler = null;
    }
};

window.navPill = {
    active: function () {
        return document.querySelector("#nav-wrap .nav-link.nav-active");
    },

    move: function (el, animate) {
        const pill = document.getElementById("nav-pill");
        const wrap = document.getElementById("nav-wrap");
        if (!pill || !wrap) return;

        wrap.querySelectorAll(".nav-link").forEach(function (l) {
            l.classList.toggle("pill-on", l === el);
        });

        if (!el) { pill.style.opacity = 0; return; }

        if (!animate) pill.style.transition = "none";
        pill.style.width = el.offsetWidth + "px";
        pill.style.transform = "translateX(" + el.offsetLeft + "px)";
        pill.style.opacity = 1;
        if (!animate) { void pill.offsetWidth; pill.style.transition = ""; }
    },

    update: function (first) {
        const wrap = document.getElementById("nav-wrap");
        if (!wrap) return;
        const self = this;

        if (!wrap.dataset.bound) {
            wrap.dataset.bound = "1";
            wrap.querySelectorAll(".nav-link").forEach(function (l) {
                l.addEventListener("mouseenter", function () { self.move(l, true); });
            });
            wrap.addEventListener("mouseleave", function () { self.move(self.active(), true); });
            window.addEventListener("resize", function () { self.move(self.active(), false); });
        }

        setTimeout(function () { self.move(self.active(), !first); }, 30);
    }
};