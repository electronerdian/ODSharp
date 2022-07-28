namespace ODSharp.Generated;
public partial class C_
{
    public C_(FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vbus_voltage, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> ibus, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ibus_report_filter_k, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> serial_number, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> hw_version_major, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> hw_version_minor, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> hw_version_variant, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> fw_version_major, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> fw_version_minor, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> fw_version_revision, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> commit_hash, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> fw_version_unreleased, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> n_evt_sampling, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> n_evt_control_loop, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> task_timers_armed, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> user_config_loaded, FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> misconfigured, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> test_property, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> reboot_required, C_task_times task_times, C_system_stats system_stats, C_oscilloscope oscilloscope, C_can can, C_amt21_encoder_group0 amt21_encoder_group0, C_issues issues, C_config config, C_axis0 axis0, C_onboard_encoder0 onboard_encoder0, C_inc_encoder0 inc_encoder0, C_inc_encoder1 inc_encoder1, C_hall_encoder0 hall_encoder0, C_hall_encoder1 hall_encoder1, C_spi_encoder0 spi_encoder0, C_spi_encoder1 spi_encoder1, C_encoder_estimator0 encoder_estimator0, C_encoder_estimator1 encoder_estimator1, F_test_function test_function, F_get_adc_voltage get_adc_voltage, F_save_configuration save_configuration, F_erase_configuration erase_configuration, F_reboot reboot, F_enter_dfu_mode enter_dfu_mode, F_get_interrupt_status get_interrupt_status, F_get_dma_status get_dma_status, F_get_gpio_states get_gpio_states, F_set_gpio set_gpio, F_get_drv_fault get_drv_fault, F_clear_errors clear_errors, F_get_raw get_raw)
    {
        this.vbus_voltage = vbus_voltage;
        this.ibus = ibus;
        this.ibus_report_filter_k = ibus_report_filter_k;
        this.serial_number = serial_number;
        this.hw_version_major = hw_version_major;
        this.hw_version_minor = hw_version_minor;
        this.hw_version_variant = hw_version_variant;
        this.fw_version_major = fw_version_major;
        this.fw_version_minor = fw_version_minor;
        this.fw_version_revision = fw_version_revision;
        this.commit_hash = commit_hash;
        this.fw_version_unreleased = fw_version_unreleased;
        this.n_evt_sampling = n_evt_sampling;
        this.n_evt_control_loop = n_evt_control_loop;
        this.task_timers_armed = task_timers_armed;
        this.user_config_loaded = user_config_loaded;
        this.misconfigured = misconfigured;
        this.test_property = test_property;
        this.reboot_required = reboot_required;
        this.task_times = task_times;
        this.system_stats = system_stats;
        this.oscilloscope = oscilloscope;
        this.can = can;
        this.amt21_encoder_group0 = amt21_encoder_group0;
        this.issues = issues;
        this.config = config;
        this.axis0 = axis0;
        this.onboard_encoder0 = onboard_encoder0;
        this.inc_encoder0 = inc_encoder0;
        this.inc_encoder1 = inc_encoder1;
        this.hall_encoder0 = hall_encoder0;
        this.hall_encoder1 = hall_encoder1;
        this.spi_encoder0 = spi_encoder0;
        this.spi_encoder1 = spi_encoder1;
        this.encoder_estimator0 = encoder_estimator0;
        this.encoder_estimator1 = encoder_estimator1;
        this.test_function = test_function;
        this.get_adc_voltage = get_adc_voltage;
        this.save_configuration = save_configuration;
        this.erase_configuration = erase_configuration;
        this.reboot = reboot;
        this.enter_dfu_mode = enter_dfu_mode;
        this.get_interrupt_status = get_interrupt_status;
        this.get_dma_status = get_dma_status;
        this.get_gpio_states = get_gpio_states;
        this.set_gpio = set_gpio;
        this.get_drv_fault = get_drv_fault;
        this.clear_errors = clear_errors;
        this.get_raw = get_raw;
    }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vbus_voltage { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> ibus { get; }

    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ibus_report_filter_k { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> serial_number { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> hw_version_major { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> hw_version_minor { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> hw_version_variant { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> fw_version_major { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> fw_version_minor { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> fw_version_revision { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> commit_hash { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> fw_version_unreleased { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> n_evt_sampling { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> n_evt_control_loop { get; }

    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> task_timers_armed { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> user_config_loaded { get; }

    public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> misconfigured { get; }

    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> test_property { get; }

    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> reboot_required { get; }

    public C_task_times task_times { get; }

    public C_system_stats system_stats { get; }

    public C_oscilloscope oscilloscope { get; }

    public C_can can { get; }

    public C_amt21_encoder_group0 amt21_encoder_group0 { get; }

    public C_issues issues { get; }

    public C_config config { get; }

    public C_axis0 axis0 { get; }

    public C_onboard_encoder0 onboard_encoder0 { get; }

    public C_inc_encoder0 inc_encoder0 { get; }

    public C_inc_encoder1 inc_encoder1 { get; }

    public C_hall_encoder0 hall_encoder0 { get; }

    public C_hall_encoder1 hall_encoder1 { get; }

    public C_spi_encoder0 spi_encoder0 { get; }

    public C_spi_encoder1 spi_encoder1 { get; }

    public C_encoder_estimator0 encoder_estimator0 { get; }

    public C_encoder_estimator1 encoder_estimator1 { get; }

    public F_test_function test_function { get; }

    public F_get_adc_voltage get_adc_voltage { get; }

    public F_save_configuration save_configuration { get; }

    public F_erase_configuration erase_configuration { get; }

    public F_reboot reboot { get; }

    public F_enter_dfu_mode enter_dfu_mode { get; }

    public F_get_interrupt_status get_interrupt_status { get; }

    public F_get_dma_status get_dma_status { get; }

    public F_get_gpio_states get_gpio_states { get; }

    public F_set_gpio set_gpio { get; }

    public F_get_drv_fault get_drv_fault { get; }

    public F_clear_errors clear_errors { get; }

    public F_get_raw get_raw { get; }

    public static C_ Construct(FibreSharp.ILegacyFibreClient _comm)
    {
        return new C_(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "vbus_voltage"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "ibus"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "ibus_report_filter_k"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt64>(_comm, "serial_number"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hw_version_major"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hw_version_minor"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hw_version_variant"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "fw_version_major"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "fw_version_minor"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "fw_version_revision"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "commit_hash"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "fw_version_unreleased"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "n_evt_sampling"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "n_evt_control_loop"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "task_timers_armed"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "user_config_loaded"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "misconfigured"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "test_property"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "reboot_required"), C_task_times.Construct(_comm), C_system_stats.Construct(_comm), C_oscilloscope.Construct(_comm), C_can.Construct(_comm), C_amt21_encoder_group0.Construct(_comm), C_issues.Construct(_comm), C_config.Construct(_comm), C_axis0.Construct(_comm), C_onboard_encoder0.Construct(_comm), C_inc_encoder0.Construct(_comm), C_inc_encoder1.Construct(_comm), C_hall_encoder0.Construct(_comm), C_hall_encoder1.Construct(_comm), C_spi_encoder0.Construct(_comm), C_spi_encoder1.Construct(_comm), C_encoder_estimator0.Construct(_comm), C_encoder_estimator1.Construct(_comm), F_test_function.Construct(_comm), F_get_adc_voltage.Construct(_comm), F_save_configuration.Construct(_comm), F_erase_configuration.Construct(_comm), F_reboot.Construct(_comm), F_enter_dfu_mode.Construct(_comm), F_get_interrupt_status.Construct(_comm), F_get_dma_status.Construct(_comm), F_get_gpio_states.Construct(_comm), F_set_gpio.Construct(_comm), F_get_drv_fault.Construct(_comm), F_clear_errors.Construct(_comm), F_get_raw.Construct(_comm));
    }

    public partial class C_task_times
    {
        public C_task_times(C_sampling sampling, C_encoder_update encoder_update, C_control_loop_misc control_loop_misc, C_control_loop_checks control_loop_checks, C_current_sense_wait current_sense_wait, C_dc_calib_wait dc_calib_wait)
        {
            this.sampling = sampling;
            this.encoder_update = encoder_update;
            this.control_loop_misc = control_loop_misc;
            this.control_loop_checks = control_loop_checks;
            this.current_sense_wait = current_sense_wait;
            this.dc_calib_wait = dc_calib_wait;
        }

        public C_sampling sampling { get; }

        public C_encoder_update encoder_update { get; }

        public C_control_loop_misc control_loop_misc { get; }

        public C_control_loop_checks control_loop_checks { get; }

        public C_current_sense_wait current_sense_wait { get; }

        public C_dc_calib_wait dc_calib_wait { get; }

        public static C_task_times Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_task_times(C_sampling.Construct(_comm), C_encoder_update.Construct(_comm), C_control_loop_misc.Construct(_comm), C_control_loop_checks.Construct(_comm), C_current_sense_wait.Construct(_comm), C_dc_calib_wait.Construct(_comm));
        }

        public partial class C_sampling
        {
            public C_sampling(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
            {
                this.start_time = start_time;
                this.end_time = end_time;
                this.length = length;
                this.max_length = max_length;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

            public static C_sampling Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_sampling(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.sampling.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.sampling.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.sampling.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.sampling.max_length"));
            }
        }

        public partial class C_encoder_update
        {
            public C_encoder_update(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
            {
                this.start_time = start_time;
                this.end_time = end_time;
                this.length = length;
                this.max_length = max_length;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

            public static C_encoder_update Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_encoder_update(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.encoder_update.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.encoder_update.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.encoder_update.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.encoder_update.max_length"));
            }
        }

        public partial class C_control_loop_misc
        {
            public C_control_loop_misc(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
            {
                this.start_time = start_time;
                this.end_time = end_time;
                this.length = length;
                this.max_length = max_length;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

            public static C_control_loop_misc Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_control_loop_misc(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.control_loop_misc.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.control_loop_misc.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.control_loop_misc.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.control_loop_misc.max_length"));
            }
        }

        public partial class C_control_loop_checks
        {
            public C_control_loop_checks(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
            {
                this.start_time = start_time;
                this.end_time = end_time;
                this.length = length;
                this.max_length = max_length;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

            public static C_control_loop_checks Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_control_loop_checks(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.control_loop_checks.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.control_loop_checks.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.control_loop_checks.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.control_loop_checks.max_length"));
            }
        }

        public partial class C_current_sense_wait
        {
            public C_current_sense_wait(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
            {
                this.start_time = start_time;
                this.end_time = end_time;
                this.length = length;
                this.max_length = max_length;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

            public static C_current_sense_wait Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_current_sense_wait(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.current_sense_wait.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.current_sense_wait.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.current_sense_wait.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.current_sense_wait.max_length"));
            }
        }

        public partial class C_dc_calib_wait
        {
            public C_dc_calib_wait(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
            {
                this.start_time = start_time;
                this.end_time = end_time;
                this.length = length;
                this.max_length = max_length;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

            public static C_dc_calib_wait Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_dc_calib_wait(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.dc_calib_wait.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.dc_calib_wait.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.dc_calib_wait.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "task_times.dc_calib_wait.max_length"));
            }
        }
    }

    public partial class C_system_stats
    {
        public C_system_stats(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> uptime, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> min_heap_space, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> max_stack_usage_axis, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> max_stack_usage_usb, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> max_stack_usage_uart, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> max_stack_usage_can, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> max_stack_usage_startup, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> stack_size_axis, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> stack_size_usb, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> stack_size_uart, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> stack_size_startup, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> stack_size_can, FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> prio_axis, FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> prio_usb, FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> prio_uart, FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> prio_startup, FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> prio_can, C_usb usb, C_i2c i2c)
        {
            this.uptime = uptime;
            this.min_heap_space = min_heap_space;
            this.max_stack_usage_axis = max_stack_usage_axis;
            this.max_stack_usage_usb = max_stack_usage_usb;
            this.max_stack_usage_uart = max_stack_usage_uart;
            this.max_stack_usage_can = max_stack_usage_can;
            this.max_stack_usage_startup = max_stack_usage_startup;
            this.stack_size_axis = stack_size_axis;
            this.stack_size_usb = stack_size_usb;
            this.stack_size_uart = stack_size_uart;
            this.stack_size_startup = stack_size_startup;
            this.stack_size_can = stack_size_can;
            this.prio_axis = prio_axis;
            this.prio_usb = prio_usb;
            this.prio_uart = prio_uart;
            this.prio_startup = prio_startup;
            this.prio_can = prio_can;
            this.usb = usb;
            this.i2c = i2c;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> uptime { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> min_heap_space { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> max_stack_usage_axis { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> max_stack_usage_usb { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> max_stack_usage_uart { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> max_stack_usage_can { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> max_stack_usage_startup { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> stack_size_axis { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> stack_size_usb { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> stack_size_uart { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> stack_size_startup { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> stack_size_can { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> prio_axis { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> prio_usb { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> prio_uart { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> prio_startup { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> prio_can { get; }

        public C_usb usb { get; }

        public C_i2c i2c { get; }

        public static C_system_stats Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_system_stats(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.uptime"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.min_heap_space"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.max_stack_usage_axis"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.max_stack_usage_usb"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.max_stack_usage_uart"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.max_stack_usage_can"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.max_stack_usage_startup"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.stack_size_axis"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.stack_size_usb"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.stack_size_uart"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.stack_size_startup"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.stack_size_can"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Int32>(_comm, "system_stats.prio_axis"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Int32>(_comm, "system_stats.prio_usb"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Int32>(_comm, "system_stats.prio_uart"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Int32>(_comm, "system_stats.prio_startup"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Int32>(_comm, "system_stats.prio_can"), C_usb.Construct(_comm), C_i2c.Construct(_comm));
        }

        public partial class C_usb
        {
            public C_usb(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> rx_cnt, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> tx_cnt, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> tx_overrun_cnt)
            {
                this.rx_cnt = rx_cnt;
                this.tx_cnt = tx_cnt;
                this.tx_overrun_cnt = tx_overrun_cnt;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> rx_cnt { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> tx_cnt { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> tx_overrun_cnt { get; }

            public static C_usb Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_usb(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.usb.rx_cnt"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.usb.tx_cnt"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.usb.tx_overrun_cnt"));
            }
        }

        public partial class C_i2c
        {
            public C_i2c(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> addr, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> addr_match_cnt, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> rx_cnt, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> error_cnt)
            {
                this.addr = addr;
                this.addr_match_cnt = addr_match_cnt;
                this.rx_cnt = rx_cnt;
                this.error_cnt = error_cnt;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> addr { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> addr_match_cnt { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> rx_cnt { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> error_cnt { get; }

            public static C_i2c Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_i2c(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "system_stats.i2c.addr"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.i2c.addr_match_cnt"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.i2c.rx_cnt"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "system_stats.i2c.error_cnt"));
            }
        }
    }

    public partial class C_oscilloscope
    {
        public C_oscilloscope(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> size, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> pos, FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> rollover, FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> recording, F_config config, F_trigger trigger, F_trigger_high_res trigger_high_res, F_get_raw get_raw)
        {
            this.size = size;
            this.pos = pos;
            this.rollover = rollover;
            this.recording = recording;
            this.config = config;
            this.trigger = trigger;
            this.trigger_high_res = trigger_high_res;
            this.get_raw = get_raw;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> size { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> pos { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> rollover { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> recording { get; }

        public F_config config { get; }

        public F_trigger trigger { get; }

        public F_trigger_high_res trigger_high_res { get; }

        public F_get_raw get_raw { get; }

        public static C_oscilloscope Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_oscilloscope(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.size"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.pos"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "oscilloscope.rollover"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "oscilloscope.recording"), F_config.Construct(_comm), F_trigger.Construct(_comm), F_trigger_high_res.Construct(_comm), F_get_raw.Construct(_comm));
        }

        public class F_config
        {
            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr0 { get; }

            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr1 { get; }

            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr2 { get; }

            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr3 { get; }

            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr4 { get; }

            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr5 { get; }

            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr6 { get; }

            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr7 { get; }

            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr8 { get; }

            private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
            FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
            public async System.Threading.Tasks.Task InvokeAsync(System.UInt32 addr0, System.UInt32 addr1, System.UInt32 addr2, System.UInt32 addr3, System.UInt32 addr4, System.UInt32 addr5, System.UInt32 addr6, System.UInt32 addr7, System.UInt32 addr8)
            {
                await this.addr0.SetAsync(addr0);
                await this.addr1.SetAsync(addr1);
                await this.addr2.SetAsync(addr2);
                await this.addr3.SetAsync(addr3);
                await this.addr4.SetAsync(addr4);
                await this.addr5.SetAsync(addr5);
                await this.addr6.SetAsync(addr6);
                await this.addr7.SetAsync(addr7);
                await this.addr8.SetAsync(addr8);
                await this._invoker.CallAsync();
            }

            F_config(FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr0, FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr1, FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr2, FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr3, FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr4, FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr5, FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr6, FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr7, FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> addr8, FibreSharp.HighLevel.ICallInvoker _invoker)
            {
                this.addr0 = addr0;
                this.addr1 = addr1;
                this.addr2 = addr2;
                this.addr3 = addr3;
                this.addr4 = addr4;
                this.addr5 = addr5;
                this.addr6 = addr6;
                this.addr7 = addr7;
                this.addr8 = addr8;
                this._invoker = _invoker;
            }

            public static F_config Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new F_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.config.addr0"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.config.addr1"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.config.addr2"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.config.addr3"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.config.addr4"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.config.addr5"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.config.addr6"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.config.addr7"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.config.addr8"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "oscilloscope.config"));
            }
        }

        public class F_trigger
        {
            public FibreSharp.HighLevel.IWriteScalarAccessor<System.Single> trigger_point { get; }

            private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
            FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
            public async System.Threading.Tasks.Task InvokeAsync(System.Single trigger_point)
            {
                await this.trigger_point.SetAsync(trigger_point);
                await this._invoker.CallAsync();
            }

            F_trigger(FibreSharp.HighLevel.IWriteScalarAccessor<System.Single> trigger_point, FibreSharp.HighLevel.ICallInvoker _invoker)
            {
                this.trigger_point = trigger_point;
                this._invoker = _invoker;
            }

            public static F_trigger Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new F_trigger(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "oscilloscope.trigger.trigger_point"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "oscilloscope.trigger"));
            }
        }

        public class F_trigger_high_res
        {
            private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
            FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
            public async System.Threading.Tasks.Task InvokeAsync()
            {
                await this._invoker.CallAsync();
            }

            F_trigger_high_res(FibreSharp.HighLevel.ICallInvoker _invoker)
            {
                this._invoker = _invoker;
            }

            public static F_trigger_high_res Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new F_trigger_high_res(FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "oscilloscope.trigger_high_res"));
            }
        }

        public class F_get_raw
        {
            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> offset { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> val0 { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> val1 { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> val2 { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> val3 { get; }

            private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
            FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
            public async System.Threading.Tasks.Task<(System.UInt64 val0, System.UInt64 val1, System.UInt64 val2, System.UInt64 val3)> InvokeAsync(System.UInt32 offset)
            {
                await this.offset.SetAsync(offset);
                await this._invoker.CallAsync();
                return (await this.val0.GetAsync(), await this.val1.GetAsync(), await this.val2.GetAsync(), await this.val3.GetAsync());
            }

            F_get_raw(FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> offset, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> val0, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> val1, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> val2, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> val3, FibreSharp.HighLevel.ICallInvoker _invoker)
            {
                this.offset = offset;
                this.val0 = val0;
                this.val1 = val1;
                this.val2 = val2;
                this.val3 = val3;
                this._invoker = _invoker;
            }

            public static F_get_raw Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new F_get_raw(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "oscilloscope.get_raw.offset"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt64>(_comm, "oscilloscope.get_raw.val0"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt64>(_comm, "oscilloscope.get_raw.val1"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt64>(_comm, "oscilloscope.get_raw.val2"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt64>(_comm, "oscilloscope.get_raw.val3"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "oscilloscope.get_raw"));
            }
        }
    }

    public partial class C_can
    {
        public C_can(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> error, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> n_restarts, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> n_rx, C_config config)
        {
            this.error = error;
            this.n_restarts = n_restarts;
            this.n_rx = n_rx;
            this.config = config;
        }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> error { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> n_restarts { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> n_rx { get; }

        public C_config config { get; }

        public static C_can Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_can(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "can.error"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "can.n_restarts"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "can.n_rx"), C_config.Construct(_comm));
        }

        public partial class C_config
        {
            public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> baud_rate, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> protocol)
            {
                this.baud_rate = baud_rate;
                this.protocol = protocol;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> baud_rate { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> protocol { get; }

            public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "can.config.baud_rate"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "can.config.protocol"));
            }
        }
    }

    public partial class C_amt21_encoder_group0
    {
        public C_amt21_encoder_group0(C_config config)
        {
            this.config = config;
        }

        public C_config config { get; }

        public static C_amt21_encoder_group0 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_amt21_encoder_group0(C_config.Construct(_comm));
        }

        public partial class C_config
        {
            public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> rs485, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> addr0)
            {
                this.enable = enable;
                this.rs485 = rs485;
                this.gpio = gpio;
                this.addr0 = addr0;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> rs485 { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> addr0 { get; }

            public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "amt21_encoder_group0.config.enable"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "amt21_encoder_group0.config.rs485"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "amt21_encoder_group0.config.gpio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "amt21_encoder_group0.config.addr0"));
            }
        }
    }

    public partial class C_issues
    {
        public C_issues(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, F_get get)
        {
            this.length = length;
            this.get = get;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

        public F_get get { get; }

        public static C_issues Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_issues(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "issues.length"), F_get.Construct(_comm));
        }

        public class F_get
        {
            public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> index { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> addr { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> line { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> arg1 { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> arg2 { get; }

            private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
            FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
            public async System.Threading.Tasks.Task<(System.UInt32 addr, System.UInt32 line, System.UInt32 arg1, System.UInt32 arg2)> InvokeAsync(System.UInt32 index)
            {
                await this.index.SetAsync(index);
                await this._invoker.CallAsync();
                return (await this.addr.GetAsync(), await this.line.GetAsync(), await this.arg1.GetAsync(), await this.arg2.GetAsync());
            }

            F_get(FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> index, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> addr, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> line, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> arg1, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> arg2, FibreSharp.HighLevel.ICallInvoker _invoker)
            {
                this.index = index;
                this.addr = addr;
                this.line = line;
                this.arg1 = arg1;
                this.arg2 = arg2;
                this._invoker = _invoker;
            }

            public static F_get Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new F_get(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "issues.get.index"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "issues.get.addr"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "issues.get.line"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "issues.get.arg1"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "issues.get.arg2"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "issues.get"));
            }
        }
    }

    public partial class C_config
    {
        public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_uart_a, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_uart_b, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_uart_c, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> uart_a_baudrate, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> uart_b_baudrate, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> uart_c_baudrate, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_can_a, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_i2c_a, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> usb_cdc_protocol, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> uart0_protocol, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> uart1_protocol, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> uart2_protocol, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> max_regen_current, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> dc_bus_undervoltage_trip_level, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> dc_bus_overvoltage_trip_level, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> dc_max_positive_current, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> dc_max_negative_current, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio0_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio1_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio2_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio3_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio4_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio5_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio6_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio7_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio8_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio9_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio10_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio11_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio12_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio13_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio14_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio15_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio16_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio17_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio18_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio19_mode, C_gpio8_pwm_mapping gpio8_pwm_mapping, C_gpio9_pwm_mapping gpio9_pwm_mapping, C_gpio15_analog_mapping gpio15_analog_mapping, C_gpio16_analog_mapping gpio16_analog_mapping, C_inverter0 inverter0, C_odrv_fan odrv_fan, C_motor_fan motor_fan)
        {
            this.enable_uart_a = enable_uart_a;
            this.enable_uart_b = enable_uart_b;
            this.enable_uart_c = enable_uart_c;
            this.uart_a_baudrate = uart_a_baudrate;
            this.uart_b_baudrate = uart_b_baudrate;
            this.uart_c_baudrate = uart_c_baudrate;
            this.enable_can_a = enable_can_a;
            this.enable_i2c_a = enable_i2c_a;
            this.usb_cdc_protocol = usb_cdc_protocol;
            this.uart0_protocol = uart0_protocol;
            this.uart1_protocol = uart1_protocol;
            this.uart2_protocol = uart2_protocol;
            this.max_regen_current = max_regen_current;
            this.dc_bus_undervoltage_trip_level = dc_bus_undervoltage_trip_level;
            this.dc_bus_overvoltage_trip_level = dc_bus_overvoltage_trip_level;
            this.dc_max_positive_current = dc_max_positive_current;
            this.dc_max_negative_current = dc_max_negative_current;
            this.gpio0_mode = gpio0_mode;
            this.gpio1_mode = gpio1_mode;
            this.gpio2_mode = gpio2_mode;
            this.gpio3_mode = gpio3_mode;
            this.gpio4_mode = gpio4_mode;
            this.gpio5_mode = gpio5_mode;
            this.gpio6_mode = gpio6_mode;
            this.gpio7_mode = gpio7_mode;
            this.gpio8_mode = gpio8_mode;
            this.gpio9_mode = gpio9_mode;
            this.gpio10_mode = gpio10_mode;
            this.gpio11_mode = gpio11_mode;
            this.gpio12_mode = gpio12_mode;
            this.gpio13_mode = gpio13_mode;
            this.gpio14_mode = gpio14_mode;
            this.gpio15_mode = gpio15_mode;
            this.gpio16_mode = gpio16_mode;
            this.gpio17_mode = gpio17_mode;
            this.gpio18_mode = gpio18_mode;
            this.gpio19_mode = gpio19_mode;
            this.gpio8_pwm_mapping = gpio8_pwm_mapping;
            this.gpio9_pwm_mapping = gpio9_pwm_mapping;
            this.gpio15_analog_mapping = gpio15_analog_mapping;
            this.gpio16_analog_mapping = gpio16_analog_mapping;
            this.inverter0 = inverter0;
            this.odrv_fan = odrv_fan;
            this.motor_fan = motor_fan;
        }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_uart_a { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_uart_b { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_uart_c { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> uart_a_baudrate { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> uart_b_baudrate { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> uart_c_baudrate { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_can_a { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_i2c_a { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> usb_cdc_protocol { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> uart0_protocol { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> uart1_protocol { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> uart2_protocol { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> max_regen_current { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> dc_bus_undervoltage_trip_level { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> dc_bus_overvoltage_trip_level { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> dc_max_positive_current { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> dc_max_negative_current { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio0_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio1_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio2_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio3_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio4_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio5_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio6_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio7_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio8_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio9_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio10_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio11_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio12_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio13_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio14_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio15_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio16_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio17_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio18_mode { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> gpio19_mode { get; }

        public C_gpio8_pwm_mapping gpio8_pwm_mapping { get; }

        public C_gpio9_pwm_mapping gpio9_pwm_mapping { get; }

        public C_gpio15_analog_mapping gpio15_analog_mapping { get; }

        public C_gpio16_analog_mapping gpio16_analog_mapping { get; }

        public C_inverter0 inverter0 { get; }

        public C_odrv_fan odrv_fan { get; }

        public C_motor_fan motor_fan { get; }

        public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "config.enable_uart_a"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "config.enable_uart_b"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "config.enable_uart_c"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "config.uart_a_baudrate"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "config.uart_b_baudrate"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "config.uart_c_baudrate"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "config.enable_can_a"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "config.enable_i2c_a"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.usb_cdc_protocol"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.uart0_protocol"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.uart1_protocol"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.uart2_protocol"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.max_regen_current"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.dc_bus_undervoltage_trip_level"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.dc_bus_overvoltage_trip_level"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.dc_max_positive_current"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.dc_max_negative_current"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio0_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio1_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio2_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio3_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio4_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio5_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio6_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio7_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio8_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio9_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio10_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio11_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio12_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio13_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio14_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio15_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio16_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio17_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio18_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "config.gpio19_mode"), C_gpio8_pwm_mapping.Construct(_comm), C_gpio9_pwm_mapping.Construct(_comm), C_gpio15_analog_mapping.Construct(_comm), C_gpio16_analog_mapping.Construct(_comm), C_inverter0.Construct(_comm), C_odrv_fan.Construct(_comm), C_motor_fan.Construct(_comm));
        }

        public partial class C_gpio8_pwm_mapping
        {
            public C_gpio8_pwm_mapping(FibreSharp.HighLevel.IReadWriteScalarAccessor<FibreSharp.LegacyManifestParser.EndpointRef> endpoint, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> min, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> max)
            {
                this.endpoint = endpoint;
                this.min = min;
                this.max = max;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<FibreSharp.LegacyManifestParser.EndpointRef> endpoint { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> min { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> max { get; }

            public static C_gpio8_pwm_mapping Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_gpio8_pwm_mapping(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<FibreSharp.LegacyManifestParser.EndpointRef>(_comm, "config.gpio8_pwm_mapping.endpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.gpio8_pwm_mapping.min"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.gpio8_pwm_mapping.max"));
            }
        }

        public partial class C_gpio9_pwm_mapping
        {
            public C_gpio9_pwm_mapping(FibreSharp.HighLevel.IReadWriteScalarAccessor<FibreSharp.LegacyManifestParser.EndpointRef> endpoint, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> min, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> max)
            {
                this.endpoint = endpoint;
                this.min = min;
                this.max = max;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<FibreSharp.LegacyManifestParser.EndpointRef> endpoint { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> min { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> max { get; }

            public static C_gpio9_pwm_mapping Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_gpio9_pwm_mapping(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<FibreSharp.LegacyManifestParser.EndpointRef>(_comm, "config.gpio9_pwm_mapping.endpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.gpio9_pwm_mapping.min"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.gpio9_pwm_mapping.max"));
            }
        }

        public partial class C_gpio15_analog_mapping
        {
            public C_gpio15_analog_mapping(FibreSharp.HighLevel.IReadWriteScalarAccessor<FibreSharp.LegacyManifestParser.EndpointRef> endpoint, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> min, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> max)
            {
                this.endpoint = endpoint;
                this.min = min;
                this.max = max;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<FibreSharp.LegacyManifestParser.EndpointRef> endpoint { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> min { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> max { get; }

            public static C_gpio15_analog_mapping Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_gpio15_analog_mapping(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<FibreSharp.LegacyManifestParser.EndpointRef>(_comm, "config.gpio15_analog_mapping.endpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.gpio15_analog_mapping.min"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.gpio15_analog_mapping.max"));
            }
        }

        public partial class C_gpio16_analog_mapping
        {
            public C_gpio16_analog_mapping(FibreSharp.HighLevel.IReadWriteScalarAccessor<FibreSharp.LegacyManifestParser.EndpointRef> endpoint, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> min, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> max)
            {
                this.endpoint = endpoint;
                this.min = min;
                this.max = max;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<FibreSharp.LegacyManifestParser.EndpointRef> endpoint { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> min { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> max { get; }

            public static C_gpio16_analog_mapping Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_gpio16_analog_mapping(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<FibreSharp.LegacyManifestParser.EndpointRef>(_comm, "config.gpio16_analog_mapping.endpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.gpio16_analog_mapping.min"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.gpio16_analog_mapping.max"));
            }
        }

        public partial class C_inverter0
        {
            public C_inverter0(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_soft_max, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_hard_max, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> shunt_conductance, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt64> drv_config)
            {
                this.current_soft_max = current_soft_max;
                this.current_hard_max = current_hard_max;
                this.shunt_conductance = shunt_conductance;
                this.drv_config = drv_config;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_soft_max { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_hard_max { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> shunt_conductance { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt64> drv_config { get; }

            public static C_inverter0 Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_inverter0(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.inverter0.current_soft_max"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.inverter0.current_hard_max"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.inverter0.shunt_conductance"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt64>(_comm, "config.inverter0.drv_config"));
            }
        }

        public partial class C_odrv_fan
        {
            public C_odrv_fan(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> upper, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> lower, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled)
            {
                this.upper = upper;
                this.lower = lower;
                this.enabled = enabled;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> upper { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> lower { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled { get; }

            public static C_odrv_fan Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_odrv_fan(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.odrv_fan.upper"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.odrv_fan.lower"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "config.odrv_fan.enabled"));
            }
        }

        public partial class C_motor_fan
        {
            public C_motor_fan(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> upper, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> lower, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled)
            {
                this.upper = upper;
                this.lower = lower;
                this.enabled = enabled;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> upper { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> lower { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled { get; }

            public static C_motor_fan Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_motor_fan(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.motor_fan.upper"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "config.motor_fan.lower"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "config.motor_fan.enabled"));
            }
        }
    }

    public partial class C_axis0
    {
        public C_axis0(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> active_errors, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> disarm_reason, FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> step_dir_active, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> last_drv_fault, FibreSharp.HighLevel.IReadScalarAccessor<System.Int64> steps, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> current_state, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> requested_state, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> is_homed, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> procedure_result, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> disarm_time, FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> is_armed, C_config config, C_motor motor, C_controller controller, C_trap_traj trap_traj, C_min_endstop min_endstop, C_max_endstop max_endstop, C_mechanical_brake mechanical_brake, C_pos_vel_mapper pos_vel_mapper, C_commutation_mapper commutation_mapper, C_interpolator interpolator, C_task_times task_times, F_watchdog_feed watchdog_feed, F_set_abs_pos set_abs_pos)
        {
            this.active_errors = active_errors;
            this.disarm_reason = disarm_reason;
            this.step_dir_active = step_dir_active;
            this.last_drv_fault = last_drv_fault;
            this.steps = steps;
            this.current_state = current_state;
            this.requested_state = requested_state;
            this.is_homed = is_homed;
            this.procedure_result = procedure_result;
            this.disarm_time = disarm_time;
            this.is_armed = is_armed;
            this.config = config;
            this.motor = motor;
            this.controller = controller;
            this.trap_traj = trap_traj;
            this.min_endstop = min_endstop;
            this.max_endstop = max_endstop;
            this.mechanical_brake = mechanical_brake;
            this.pos_vel_mapper = pos_vel_mapper;
            this.commutation_mapper = commutation_mapper;
            this.interpolator = interpolator;
            this.task_times = task_times;
            this.watchdog_feed = watchdog_feed;
            this.set_abs_pos = set_abs_pos;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> active_errors { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> disarm_reason { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> step_dir_active { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> last_drv_fault { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Int64> steps { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> current_state { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> requested_state { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> is_homed { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> procedure_result { get; }

        public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> disarm_time { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> is_armed { get; }

        public C_config config { get; }

        public C_motor motor { get; }

        public C_controller controller { get; }

        public C_trap_traj trap_traj { get; }

        public C_min_endstop min_endstop { get; }

        public C_max_endstop max_endstop { get; }

        public C_mechanical_brake mechanical_brake { get; }

        public C_pos_vel_mapper pos_vel_mapper { get; }

        public C_commutation_mapper commutation_mapper { get; }

        public C_interpolator interpolator { get; }

        public C_task_times task_times { get; }

        public F_watchdog_feed watchdog_feed { get; }

        public F_set_abs_pos set_abs_pos { get; }

        public static C_axis0 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_axis0(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.active_errors"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.disarm_reason"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.step_dir_active"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.last_drv_fault"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Int64>(_comm, "axis0.steps"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.current_state"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.requested_state"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.is_homed"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.procedure_result"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.disarm_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.is_armed"), C_config.Construct(_comm), C_motor.Construct(_comm), C_controller.Construct(_comm), C_trap_traj.Construct(_comm), C_min_endstop.Construct(_comm), C_max_endstop.Construct(_comm), C_mechanical_brake.Construct(_comm), C_pos_vel_mapper.Construct(_comm), C_commutation_mapper.Construct(_comm), C_interpolator.Construct(_comm), C_task_times.Construct(_comm), F_watchdog_feed.Construct(_comm), F_set_abs_pos.Construct(_comm));
        }

        public partial class C_config
        {
            public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> startup_motor_calibration, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> startup_encoder_index_search, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> startup_encoder_offset_calibration, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> startup_closed_loop_control, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> startup_homing, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_step_dir, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> step_dir_always_on, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calib_range, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calib_scan_distance, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calib_scan_vel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> index_search_at_target_vel_only, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> watchdog_timeout, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_watchdog, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> step_gpio_pin, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> dir_gpio_pin, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> error_gpio_pin, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> load_encoder, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> commutation_encoder, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> encoder_bandwidth, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> I_bus_hard_min, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> I_bus_hard_max, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_soft_min, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_soft_max, C_calibration_lockin calibration_lockin, C_sensorless_ramp sensorless_ramp, C_general_lockin general_lockin, C_can can, C_motor motor)
            {
                this.startup_motor_calibration = startup_motor_calibration;
                this.startup_encoder_index_search = startup_encoder_index_search;
                this.startup_encoder_offset_calibration = startup_encoder_offset_calibration;
                this.startup_closed_loop_control = startup_closed_loop_control;
                this.startup_homing = startup_homing;
                this.enable_step_dir = enable_step_dir;
                this.step_dir_always_on = step_dir_always_on;
                this.calib_range = calib_range;
                this.calib_scan_distance = calib_scan_distance;
                this.calib_scan_vel = calib_scan_vel;
                this.index_search_at_target_vel_only = index_search_at_target_vel_only;
                this.watchdog_timeout = watchdog_timeout;
                this.enable_watchdog = enable_watchdog;
                this.step_gpio_pin = step_gpio_pin;
                this.dir_gpio_pin = dir_gpio_pin;
                this.error_gpio_pin = error_gpio_pin;
                this.load_encoder = load_encoder;
                this.commutation_encoder = commutation_encoder;
                this.encoder_bandwidth = encoder_bandwidth;
                this.I_bus_hard_min = I_bus_hard_min;
                this.I_bus_hard_max = I_bus_hard_max;
                this.torque_soft_min = torque_soft_min;
                this.torque_soft_max = torque_soft_max;
                this.calibration_lockin = calibration_lockin;
                this.sensorless_ramp = sensorless_ramp;
                this.general_lockin = general_lockin;
                this.can = can;
                this.motor = motor;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> startup_motor_calibration { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> startup_encoder_index_search { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> startup_encoder_offset_calibration { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> startup_closed_loop_control { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> startup_homing { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_step_dir { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> step_dir_always_on { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calib_range { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calib_scan_distance { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calib_scan_vel { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> index_search_at_target_vel_only { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> watchdog_timeout { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_watchdog { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> step_gpio_pin { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> dir_gpio_pin { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> error_gpio_pin { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> load_encoder { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> commutation_encoder { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> encoder_bandwidth { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> I_bus_hard_min { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> I_bus_hard_max { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_soft_min { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_soft_max { get; }

            public C_calibration_lockin calibration_lockin { get; }

            public C_sensorless_ramp sensorless_ramp { get; }

            public C_general_lockin general_lockin { get; }

            public C_can can { get; }

            public C_motor motor { get; }

            public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.startup_motor_calibration"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.startup_encoder_index_search"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.startup_encoder_offset_calibration"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.startup_closed_loop_control"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.startup_homing"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.enable_step_dir"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.step_dir_always_on"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.calib_range"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.calib_scan_distance"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.calib_scan_vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.index_search_at_target_vel_only"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.watchdog_timeout"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.enable_watchdog"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt16>(_comm, "axis0.config.step_gpio_pin"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt16>(_comm, "axis0.config.dir_gpio_pin"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt16>(_comm, "axis0.config.error_gpio_pin"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.config.load_encoder"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.config.commutation_encoder"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.encoder_bandwidth"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.I_bus_hard_min"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.I_bus_hard_max"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.torque_soft_min"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.torque_soft_max"), C_calibration_lockin.Construct(_comm), C_sensorless_ramp.Construct(_comm), C_general_lockin.Construct(_comm), C_can.Construct(_comm), C_motor.Construct(_comm));
            }

            public partial class C_calibration_lockin
            {
                public C_calibration_lockin(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_time, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_distance, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> accel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel)
                {
                    this.current = current;
                    this.ramp_time = ramp_time;
                    this.ramp_distance = ramp_distance;
                    this.accel = accel;
                    this.vel = vel;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_time { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_distance { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> accel { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel { get; }

                public static C_calibration_lockin Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_calibration_lockin(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.calibration_lockin.current"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.calibration_lockin.ramp_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.calibration_lockin.ramp_distance"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.calibration_lockin.accel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.calibration_lockin.vel"));
                }
            }

            public partial class C_sensorless_ramp
            {
                public C_sensorless_ramp(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_time, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_distance, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> accel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> finish_distance, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> finish_on_vel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> finish_on_distance)
                {
                    this.current = current;
                    this.ramp_time = ramp_time;
                    this.ramp_distance = ramp_distance;
                    this.accel = accel;
                    this.vel = vel;
                    this.finish_distance = finish_distance;
                    this.finish_on_vel = finish_on_vel;
                    this.finish_on_distance = finish_on_distance;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_time { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_distance { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> accel { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> finish_distance { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> finish_on_vel { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> finish_on_distance { get; }

                public static C_sensorless_ramp Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_sensorless_ramp(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.sensorless_ramp.current"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.sensorless_ramp.ramp_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.sensorless_ramp.ramp_distance"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.sensorless_ramp.accel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.sensorless_ramp.vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.sensorless_ramp.finish_distance"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.sensorless_ramp.finish_on_vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.sensorless_ramp.finish_on_distance"));
                }
            }

            public partial class C_general_lockin
            {
                public C_general_lockin(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_time, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_distance, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> accel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> finish_distance, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> finish_on_vel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> finish_on_distance)
                {
                    this.current = current;
                    this.ramp_time = ramp_time;
                    this.ramp_distance = ramp_distance;
                    this.accel = accel;
                    this.vel = vel;
                    this.finish_distance = finish_distance;
                    this.finish_on_vel = finish_on_vel;
                    this.finish_on_distance = finish_on_distance;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_time { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ramp_distance { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> accel { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> finish_distance { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> finish_on_vel { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> finish_on_distance { get; }

                public static C_general_lockin Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_general_lockin(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.general_lockin.current"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.general_lockin.ramp_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.general_lockin.ramp_distance"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.general_lockin.accel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.general_lockin.vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.general_lockin.finish_distance"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.general_lockin.finish_on_vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.general_lockin.finish_on_distance"));
                }
            }

            public partial class C_can
            {
                public C_can(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> node_id, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> is_extended, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> heartbeat_rate_ms, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> encoder_rate_ms)
                {
                    this.node_id = node_id;
                    this.is_extended = is_extended;
                    this.heartbeat_rate_ms = heartbeat_rate_ms;
                    this.encoder_rate_ms = encoder_rate_ms;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> node_id { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> is_extended { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> heartbeat_rate_ms { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> encoder_rate_ms { get; }

                public static C_can Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_can(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.config.can.node_id"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.can.is_extended"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.config.can.heartbeat_rate_ms"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.config.can.encoder_rate_ms"));
                }
            }

            public partial class C_motor
            {
                public C_motor(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> motor_type, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> pole_pairs, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> phase_resistance, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> phase_inductance, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> phase_resistance_inductance_valid, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_constant, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> direction, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_control_bandwidth, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> R_wL_FF_enable, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> bEMF_FF_enable, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ff_pm_flux_linkage, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> ff_pm_flux_linkage_valid, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> motor_model_l_d, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> motor_model_l_q, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> motor_model_l_dq_valid, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calibration_current, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> resistance_calib_max_voltage, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_soft_max, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_hard_max, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_slew_rate_limit, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> acim_gain_min_flux, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> acim_autoflux_enable, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> acim_autoflux_min_Id, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> acim_autoflux_attack_gain, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> acim_autoflux_decay_gain, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> acim_nominal_slip_vel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> sensorless_observer_gain, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> sensorless_pll_bandwidth, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> sensorless_pm_flux_linkage, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> sensorless_pm_flux_linkage_valid)
                {
                    this.motor_type = motor_type;
                    this.pole_pairs = pole_pairs;
                    this.phase_resistance = phase_resistance;
                    this.phase_inductance = phase_inductance;
                    this.phase_resistance_inductance_valid = phase_resistance_inductance_valid;
                    this.torque_constant = torque_constant;
                    this.direction = direction;
                    this.current_control_bandwidth = current_control_bandwidth;
                    this.R_wL_FF_enable = R_wL_FF_enable;
                    this.bEMF_FF_enable = bEMF_FF_enable;
                    this.ff_pm_flux_linkage = ff_pm_flux_linkage;
                    this.ff_pm_flux_linkage_valid = ff_pm_flux_linkage_valid;
                    this.motor_model_l_d = motor_model_l_d;
                    this.motor_model_l_q = motor_model_l_q;
                    this.motor_model_l_dq_valid = motor_model_l_dq_valid;
                    this.calibration_current = calibration_current;
                    this.resistance_calib_max_voltage = resistance_calib_max_voltage;
                    this.current_soft_max = current_soft_max;
                    this.current_hard_max = current_hard_max;
                    this.current_slew_rate_limit = current_slew_rate_limit;
                    this.acim_gain_min_flux = acim_gain_min_flux;
                    this.acim_autoflux_enable = acim_autoflux_enable;
                    this.acim_autoflux_min_Id = acim_autoflux_min_Id;
                    this.acim_autoflux_attack_gain = acim_autoflux_attack_gain;
                    this.acim_autoflux_decay_gain = acim_autoflux_decay_gain;
                    this.acim_nominal_slip_vel = acim_nominal_slip_vel;
                    this.sensorless_observer_gain = sensorless_observer_gain;
                    this.sensorless_pll_bandwidth = sensorless_pll_bandwidth;
                    this.sensorless_pm_flux_linkage = sensorless_pm_flux_linkage;
                    this.sensorless_pm_flux_linkage_valid = sensorless_pm_flux_linkage_valid;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> motor_type { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> pole_pairs { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> phase_resistance { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> phase_inductance { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> phase_resistance_inductance_valid { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_constant { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> direction { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_control_bandwidth { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> R_wL_FF_enable { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> bEMF_FF_enable { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> ff_pm_flux_linkage { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> ff_pm_flux_linkage_valid { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> motor_model_l_d { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> motor_model_l_q { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> motor_model_l_dq_valid { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calibration_current { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> resistance_calib_max_voltage { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_soft_max { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_hard_max { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> current_slew_rate_limit { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> acim_gain_min_flux { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> acim_autoflux_enable { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> acim_autoflux_min_Id { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> acim_autoflux_attack_gain { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> acim_autoflux_decay_gain { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> acim_nominal_slip_vel { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> sensorless_observer_gain { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> sensorless_pll_bandwidth { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> sensorless_pm_flux_linkage { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> sensorless_pm_flux_linkage_valid { get; }

                public static C_motor Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_motor(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.config.motor.motor_type"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.config.motor.pole_pairs"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.phase_resistance"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.phase_inductance"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.motor.phase_resistance_inductance_valid"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.torque_constant"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.direction"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.current_control_bandwidth"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.motor.R_wL_FF_enable"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.motor.bEMF_FF_enable"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.ff_pm_flux_linkage"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.motor.ff_pm_flux_linkage_valid"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.motor_model_l_d"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.motor_model_l_q"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.motor.motor_model_l_dq_valid"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.calibration_current"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.resistance_calib_max_voltage"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.current_soft_max"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.current_hard_max"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.current_slew_rate_limit"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.acim_gain_min_flux"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.motor.acim_autoflux_enable"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.acim_autoflux_min_Id"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.acim_autoflux_attack_gain"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.acim_autoflux_decay_gain"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.acim_nominal_slip_vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.sensorless_observer_gain"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.sensorless_pll_bandwidth"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.config.motor.sensorless_pm_flux_linkage"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.config.motor.sensorless_pm_flux_linkage_valid"));
                }
            }
        }

        public partial class C_motor
        {
            public C_motor(FibreSharp.HighLevel.IReadScalarAccessor<System.Single> effective_current_lim, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> resistance_calibration_I_beta, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_id, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_iq, C_alpha_beta_controller alpha_beta_controller, C_foc foc, C_fet_thermistor fet_thermistor, C_motor_thermistor motor_thermistor, C_acim_estimator acim_estimator, C_sensorless_estimator sensorless_estimator)
            {
                this.effective_current_lim = effective_current_lim;
                this.resistance_calibration_I_beta = resistance_calibration_I_beta;
                this.input_id = input_id;
                this.input_iq = input_iq;
                this.alpha_beta_controller = alpha_beta_controller;
                this.foc = foc;
                this.fet_thermistor = fet_thermistor;
                this.motor_thermistor = motor_thermistor;
                this.acim_estimator = acim_estimator;
                this.sensorless_estimator = sensorless_estimator;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> effective_current_lim { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> resistance_calibration_I_beta { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_id { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_iq { get; }

            public C_alpha_beta_controller alpha_beta_controller { get; }

            public C_foc foc { get; }

            public C_fet_thermistor fet_thermistor { get; }

            public C_motor_thermistor motor_thermistor { get; }

            public C_acim_estimator acim_estimator { get; }

            public C_sensorless_estimator sensorless_estimator { get; }

            public static C_motor Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_motor(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.effective_current_lim"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.resistance_calibration_I_beta"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.input_id"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.input_iq"), C_alpha_beta_controller.Construct(_comm), C_foc.Construct(_comm), C_fet_thermistor.Construct(_comm), C_motor_thermistor.Construct(_comm), C_acim_estimator.Construct(_comm), C_sensorless_estimator.Construct(_comm));
            }

            public partial class C_alpha_beta_controller
            {
                public C_alpha_beta_controller(FibreSharp.HighLevel.IReadScalarAccessor<System.Single> current_meas_phA, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> current_meas_phB, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> current_meas_phC, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> current_meas_status_phA, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> current_meas_status_phB, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> current_meas_status_phC, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> I_bus, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Ialpha_measured, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Ibeta_measured, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> max_measurable_current, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> power, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> n_evt_current_measurement, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> n_evt_pwm_update)
                {
                    this.current_meas_phA = current_meas_phA;
                    this.current_meas_phB = current_meas_phB;
                    this.current_meas_phC = current_meas_phC;
                    this.current_meas_status_phA = current_meas_status_phA;
                    this.current_meas_status_phB = current_meas_status_phB;
                    this.current_meas_status_phC = current_meas_status_phC;
                    this.I_bus = I_bus;
                    this.Ialpha_measured = Ialpha_measured;
                    this.Ibeta_measured = Ibeta_measured;
                    this.max_measurable_current = max_measurable_current;
                    this.power = power;
                    this.n_evt_current_measurement = n_evt_current_measurement;
                    this.n_evt_pwm_update = n_evt_pwm_update;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> current_meas_phA { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> current_meas_phB { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> current_meas_phC { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> current_meas_status_phA { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> current_meas_status_phB { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> current_meas_status_phC { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> I_bus { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Ialpha_measured { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Ibeta_measured { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> max_measurable_current { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> power { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> n_evt_current_measurement { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> n_evt_pwm_update { get; }

                public static C_alpha_beta_controller Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_alpha_beta_controller(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.alpha_beta_controller.current_meas_phA"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.alpha_beta_controller.current_meas_phB"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.alpha_beta_controller.current_meas_phC"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.motor.alpha_beta_controller.current_meas_status_phA"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.motor.alpha_beta_controller.current_meas_status_phB"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.motor.alpha_beta_controller.current_meas_status_phC"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.alpha_beta_controller.I_bus"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.alpha_beta_controller.Ialpha_measured"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.alpha_beta_controller.Ibeta_measured"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.alpha_beta_controller.max_measurable_current"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.alpha_beta_controller.power"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.motor.alpha_beta_controller.n_evt_current_measurement"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.motor.alpha_beta_controller.n_evt_pwm_update"));
                }
            }

            public partial class C_foc
            {
                public C_foc(FibreSharp.HighLevel.IReadScalarAccessor<System.Single> p_gain, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> i_gain, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> I_measured_report_filter_k, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Id_setpoint, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Iq_setpoint, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Vd_setpoint, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Vq_setpoint, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> phase, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> phase_vel, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Id_measured, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Iq_measured, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> v_current_control_integral_d, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> v_current_control_integral_q, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> mod_d, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> mod_q, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> final_v_alpha, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> final_v_beta)
                {
                    this.p_gain = p_gain;
                    this.i_gain = i_gain;
                    this.I_measured_report_filter_k = I_measured_report_filter_k;
                    this.Id_setpoint = Id_setpoint;
                    this.Iq_setpoint = Iq_setpoint;
                    this.Vd_setpoint = Vd_setpoint;
                    this.Vq_setpoint = Vq_setpoint;
                    this.phase = phase;
                    this.phase_vel = phase_vel;
                    this.Id_measured = Id_measured;
                    this.Iq_measured = Iq_measured;
                    this.v_current_control_integral_d = v_current_control_integral_d;
                    this.v_current_control_integral_q = v_current_control_integral_q;
                    this.mod_d = mod_d;
                    this.mod_q = mod_q;
                    this.final_v_alpha = final_v_alpha;
                    this.final_v_beta = final_v_beta;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> p_gain { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> i_gain { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> I_measured_report_filter_k { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Id_setpoint { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Iq_setpoint { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Vd_setpoint { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Vq_setpoint { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> phase { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> phase_vel { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Id_measured { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> Iq_measured { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> v_current_control_integral_d { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> v_current_control_integral_q { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> mod_d { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> mod_q { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> final_v_alpha { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> final_v_beta { get; }

                public static C_foc Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_foc(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.p_gain"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.i_gain"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.I_measured_report_filter_k"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.Id_setpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.Iq_setpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.Vd_setpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.Vq_setpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.phase"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.phase_vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.Id_measured"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.Iq_measured"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.v_current_control_integral_d"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.v_current_control_integral_q"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.mod_d"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.mod_q"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.final_v_alpha"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.foc.final_v_beta"));
                }
            }

            public partial class C_fet_thermistor
            {
                public C_fet_thermistor(FibreSharp.HighLevel.IReadScalarAccessor<System.Single> temperature, C_config config)
                {
                    this.temperature = temperature;
                    this.config = config;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> temperature { get; }

                public C_config config { get; }

                public static C_fet_thermistor Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_fet_thermistor(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.fet_thermistor.temperature"), C_config.Construct(_comm));
                }

                public partial class C_config
                {
                    public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> temp_limit_lower, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> temp_limit_upper, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled)
                    {
                        this.temp_limit_lower = temp_limit_lower;
                        this.temp_limit_upper = temp_limit_upper;
                        this.enabled = enabled;
                    }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> temp_limit_lower { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> temp_limit_upper { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled { get; }

                    public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
                    {
                        return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.fet_thermistor.config.temp_limit_lower"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.fet_thermistor.config.temp_limit_upper"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.motor.fet_thermistor.config.enabled"));
                    }
                }
            }

            public partial class C_motor_thermistor
            {
                public C_motor_thermistor(FibreSharp.HighLevel.IReadScalarAccessor<System.Single> temperature, C_config config)
                {
                    this.temperature = temperature;
                    this.config = config;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> temperature { get; }

                public C_config config { get; }

                public static C_motor_thermistor Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_motor_thermistor(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.motor_thermistor.temperature"), C_config.Construct(_comm));
                }

                public partial class C_config
                {
                    public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> gpio_pin, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> poly_coefficient_0, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> poly_coefficient_1, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> poly_coefficient_2, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> poly_coefficient_3, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> temp_limit_lower, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> temp_limit_upper, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled)
                    {
                        this.gpio_pin = gpio_pin;
                        this.poly_coefficient_0 = poly_coefficient_0;
                        this.poly_coefficient_1 = poly_coefficient_1;
                        this.poly_coefficient_2 = poly_coefficient_2;
                        this.poly_coefficient_3 = poly_coefficient_3;
                        this.temp_limit_lower = temp_limit_lower;
                        this.temp_limit_upper = temp_limit_upper;
                        this.enabled = enabled;
                    }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> gpio_pin { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> poly_coefficient_0 { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> poly_coefficient_1 { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> poly_coefficient_2 { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> poly_coefficient_3 { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> temp_limit_lower { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> temp_limit_upper { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled { get; }

                    public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
                    {
                        return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt16>(_comm, "axis0.motor.motor_thermistor.config.gpio_pin"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.motor_thermistor.config.poly_coefficient_0"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.motor_thermistor.config.poly_coefficient_1"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.motor_thermistor.config.poly_coefficient_2"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.motor_thermistor.config.poly_coefficient_3"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.motor_thermistor.config.temp_limit_lower"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.motor_thermistor.config.temp_limit_upper"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.motor.motor_thermistor.config.enabled"));
                    }
                }
            }

            public partial class C_acim_estimator
            {
                public C_acim_estimator(FibreSharp.HighLevel.IReadScalarAccessor<System.Single> rotor_flux, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> slip_vel, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> phase_offset, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> stator_phase_vel, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> stator_phase)
                {
                    this.rotor_flux = rotor_flux;
                    this.slip_vel = slip_vel;
                    this.phase_offset = phase_offset;
                    this.stator_phase_vel = stator_phase_vel;
                    this.stator_phase = stator_phase;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> rotor_flux { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> slip_vel { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> phase_offset { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> stator_phase_vel { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> stator_phase { get; }

                public static C_acim_estimator Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_acim_estimator(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.acim_estimator.rotor_flux"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.acim_estimator.slip_vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.acim_estimator.phase_offset"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.acim_estimator.stator_phase_vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.acim_estimator.stator_phase"));
                }
            }

            public partial class C_sensorless_estimator
            {
                public C_sensorless_estimator(FibreSharp.HighLevel.IReadScalarAccessor<System.Single> phase, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pll_pos, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> phase_vel)
                {
                    this.phase = phase;
                    this.pll_pos = pll_pos;
                    this.phase_vel = phase_vel;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> phase { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pll_pos { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> phase_vel { get; }

                public static C_sensorless_estimator Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_sensorless_estimator(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.sensorless_estimator.phase"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.sensorless_estimator.pll_pos"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.motor.sensorless_estimator.phase_vel"));
                }
            }
        }

        public partial class C_controller
        {
            public C_controller(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_pos, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_vel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_torque, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_setpoint, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vel_setpoint, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> torque_setpoint, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> effective_torque_setpoint, FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> trajectory_done, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_integrator_torque, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> anticogging_valid, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> autotuning_phase, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> mechanical_power, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> electrical_power, C_config config, C_autotuning autotuning, F_move_incremental move_incremental, F_start_anticogging_calibration start_anticogging_calibration)
            {
                this.input_pos = input_pos;
                this.input_vel = input_vel;
                this.input_torque = input_torque;
                this.pos_setpoint = pos_setpoint;
                this.vel_setpoint = vel_setpoint;
                this.torque_setpoint = torque_setpoint;
                this.effective_torque_setpoint = effective_torque_setpoint;
                this.trajectory_done = trajectory_done;
                this.vel_integrator_torque = vel_integrator_torque;
                this.anticogging_valid = anticogging_valid;
                this.autotuning_phase = autotuning_phase;
                this.mechanical_power = mechanical_power;
                this.electrical_power = electrical_power;
                this.config = config;
                this.autotuning = autotuning;
                this.move_incremental = move_incremental;
                this.start_anticogging_calibration = start_anticogging_calibration;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_pos { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_vel { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_torque { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_setpoint { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vel_setpoint { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> torque_setpoint { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> effective_torque_setpoint { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> trajectory_done { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_integrator_torque { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> anticogging_valid { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> autotuning_phase { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> mechanical_power { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> electrical_power { get; }

            public C_config config { get; }

            public C_autotuning autotuning { get; }

            public F_move_incremental move_incremental { get; }

            public F_start_anticogging_calibration start_anticogging_calibration { get; }

            public static C_controller Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_controller(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.input_pos"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.input_vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.input_torque"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.pos_setpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.vel_setpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.torque_setpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.effective_torque_setpoint"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.trajectory_done"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.vel_integrator_torque"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.anticogging_valid"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.autotuning_phase"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.mechanical_power"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.electrical_power"), C_config.Construct(_comm), C_autotuning.Construct(_comm), F_move_incremental.Construct(_comm), F_start_anticogging_calibration.Construct(_comm));
            }

            public partial class C_config
            {
                public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> gain_scheduling_width, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_vel_limit, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_torque_mode_vel_limit, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_gain_scheduling, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_overspeed_error, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> control_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> input_mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> pos_gain, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_gain, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_integrator_gain, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_integrator_limit, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_limit, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_limit_tolerance, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_ramp_rate, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_ramp_rate, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> circular_setpoints, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> circular_setpoint_range, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> absolute_setpoints, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> use_commutation_vel, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> commutation_vel_scale, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Int32> steps_per_circular_range, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> homing_speed, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> inertia, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> axis_to_mirror, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> mirror_ratio, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_mirror_ratio, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_filter_bandwidth, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> mechanical_power_bandwidth, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> electrical_power_bandwidth, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> spinout_mechanical_power_threshold, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> spinout_electrical_power_threshold, C_anticogging anticogging)
                {
                    this.gain_scheduling_width = gain_scheduling_width;
                    this.enable_vel_limit = enable_vel_limit;
                    this.enable_torque_mode_vel_limit = enable_torque_mode_vel_limit;
                    this.enable_gain_scheduling = enable_gain_scheduling;
                    this.enable_overspeed_error = enable_overspeed_error;
                    this.control_mode = control_mode;
                    this.input_mode = input_mode;
                    this.pos_gain = pos_gain;
                    this.vel_gain = vel_gain;
                    this.vel_integrator_gain = vel_integrator_gain;
                    this.vel_integrator_limit = vel_integrator_limit;
                    this.vel_limit = vel_limit;
                    this.vel_limit_tolerance = vel_limit_tolerance;
                    this.vel_ramp_rate = vel_ramp_rate;
                    this.torque_ramp_rate = torque_ramp_rate;
                    this.circular_setpoints = circular_setpoints;
                    this.circular_setpoint_range = circular_setpoint_range;
                    this.absolute_setpoints = absolute_setpoints;
                    this.use_commutation_vel = use_commutation_vel;
                    this.commutation_vel_scale = commutation_vel_scale;
                    this.steps_per_circular_range = steps_per_circular_range;
                    this.homing_speed = homing_speed;
                    this.inertia = inertia;
                    this.axis_to_mirror = axis_to_mirror;
                    this.mirror_ratio = mirror_ratio;
                    this.torque_mirror_ratio = torque_mirror_ratio;
                    this.input_filter_bandwidth = input_filter_bandwidth;
                    this.mechanical_power_bandwidth = mechanical_power_bandwidth;
                    this.electrical_power_bandwidth = electrical_power_bandwidth;
                    this.spinout_mechanical_power_threshold = spinout_mechanical_power_threshold;
                    this.spinout_electrical_power_threshold = spinout_electrical_power_threshold;
                    this.anticogging = anticogging;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> gain_scheduling_width { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_vel_limit { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_torque_mode_vel_limit { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_gain_scheduling { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enable_overspeed_error { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> control_mode { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> input_mode { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> pos_gain { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_gain { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_integrator_gain { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_integrator_limit { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_limit { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_limit_tolerance { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_ramp_rate { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_ramp_rate { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> circular_setpoints { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> circular_setpoint_range { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> absolute_setpoints { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> use_commutation_vel { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> commutation_vel_scale { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Int32> steps_per_circular_range { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> homing_speed { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> inertia { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> axis_to_mirror { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> mirror_ratio { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_mirror_ratio { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> input_filter_bandwidth { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> mechanical_power_bandwidth { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> electrical_power_bandwidth { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> spinout_mechanical_power_threshold { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> spinout_electrical_power_threshold { get; }

                public C_anticogging anticogging { get; }

                public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.gain_scheduling_width"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.config.enable_vel_limit"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.config.enable_torque_mode_vel_limit"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.config.enable_gain_scheduling"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.config.enable_overspeed_error"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.controller.config.control_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.controller.config.input_mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.pos_gain"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.vel_gain"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.vel_integrator_gain"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.vel_integrator_limit"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.vel_limit"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.vel_limit_tolerance"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.vel_ramp_rate"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.torque_ramp_rate"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.config.circular_setpoints"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.circular_setpoint_range"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.config.absolute_setpoints"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.config.use_commutation_vel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.commutation_vel_scale"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Int32>(_comm, "axis0.controller.config.steps_per_circular_range"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.homing_speed"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.inertia"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.controller.config.axis_to_mirror"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.mirror_ratio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.torque_mirror_ratio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.input_filter_bandwidth"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.mechanical_power_bandwidth"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.electrical_power_bandwidth"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.spinout_mechanical_power_threshold"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.spinout_electrical_power_threshold"), C_anticogging.Construct(_comm));
                }

                public partial class C_anticogging
                {
                    public C_anticogging(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> index, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> pre_calibrated, FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> calib_anticogging, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calib_pos_threshold, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calib_vel_threshold, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> cogging_ratio, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> anticogging_enabled)
                    {
                        this.index = index;
                        this.pre_calibrated = pre_calibrated;
                        this.calib_anticogging = calib_anticogging;
                        this.calib_pos_threshold = calib_pos_threshold;
                        this.calib_vel_threshold = calib_vel_threshold;
                        this.cogging_ratio = cogging_ratio;
                        this.anticogging_enabled = anticogging_enabled;
                    }

                    public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> index { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> pre_calibrated { get; }

                    public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> calib_anticogging { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calib_pos_threshold { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> calib_vel_threshold { get; }

                    public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> cogging_ratio { get; }

                    public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> anticogging_enabled { get; }

                    public static C_anticogging Construct(FibreSharp.ILegacyFibreClient _comm)
                    {
                        return new C_anticogging(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.controller.config.anticogging.index"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.config.anticogging.pre_calibrated"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.config.anticogging.calib_anticogging"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.anticogging.calib_pos_threshold"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.anticogging.calib_vel_threshold"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.config.anticogging.cogging_ratio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.config.anticogging.anticogging_enabled"));
                    }
                }
            }

            public partial class C_autotuning
            {
                public C_autotuning(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> frequency, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> pos_amplitude, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_amplitude, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_amplitude, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> pos_phase, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_phase, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> vel_burst_factor, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_phase)
                {
                    this.frequency = frequency;
                    this.pos_amplitude = pos_amplitude;
                    this.vel_amplitude = vel_amplitude;
                    this.torque_amplitude = torque_amplitude;
                    this.pos_phase = pos_phase;
                    this.vel_phase = vel_phase;
                    this.vel_burst_factor = vel_burst_factor;
                    this.torque_phase = torque_phase;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> frequency { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> pos_amplitude { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_amplitude { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_amplitude { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> pos_phase { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_phase { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> vel_burst_factor { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> torque_phase { get; }

                public static C_autotuning Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_autotuning(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.autotuning.frequency"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.autotuning.pos_amplitude"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.autotuning.vel_amplitude"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.autotuning.torque_amplitude"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.autotuning.pos_phase"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.autotuning.vel_phase"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.controller.autotuning.vel_burst_factor"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.autotuning.torque_phase"));
                }
            }

            public class F_move_incremental
            {
                public FibreSharp.HighLevel.IWriteScalarAccessor<System.Single> displacement { get; }

                public FibreSharp.HighLevel.IWriteScalarAccessor<System.Boolean> from_input_pos { get; }

                private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
                FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
                public async System.Threading.Tasks.Task InvokeAsync(System.Single displacement, System.Boolean from_input_pos)
                {
                    await this.displacement.SetAsync(displacement);
                    await this.from_input_pos.SetAsync(from_input_pos);
                    await this._invoker.CallAsync();
                }

                F_move_incremental(FibreSharp.HighLevel.IWriteScalarAccessor<System.Single> displacement, FibreSharp.HighLevel.IWriteScalarAccessor<System.Boolean> from_input_pos, FibreSharp.HighLevel.ICallInvoker _invoker)
                {
                    this.displacement = displacement;
                    this.from_input_pos = from_input_pos;
                    this._invoker = _invoker;
                }

                public static F_move_incremental Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new F_move_incremental(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.controller.move_incremental.displacement"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.controller.move_incremental.from_input_pos"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "axis0.controller.move_incremental"));
                }
            }

            public class F_start_anticogging_calibration
            {
                private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
                FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
                public async System.Threading.Tasks.Task InvokeAsync()
                {
                    await this._invoker.CallAsync();
                }

                F_start_anticogging_calibration(FibreSharp.HighLevel.ICallInvoker _invoker)
                {
                    this._invoker = _invoker;
                }

                public static F_start_anticogging_calibration Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new F_start_anticogging_calibration(FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "axis0.controller.start_anticogging_calibration"));
                }
            }
        }

        public partial class C_trap_traj
        {
            public C_trap_traj(C_config config)
            {
                this.config = config;
            }

            public C_config config { get; }

            public static C_trap_traj Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_trap_traj(C_config.Construct(_comm));
            }

            public partial class C_config
            {
                public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_limit, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> accel_limit, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> decel_limit)
                {
                    this.vel_limit = vel_limit;
                    this.accel_limit = accel_limit;
                    this.decel_limit = decel_limit;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> vel_limit { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> accel_limit { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> decel_limit { get; }

                public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.trap_traj.config.vel_limit"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.trap_traj.config.accel_limit"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.trap_traj.config.decel_limit"));
                }
            }
        }

        public partial class C_min_endstop
        {
            public C_min_endstop(FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> endstop_state, C_config config)
            {
                this.endstop_state = endstop_state;
                this.config = config;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> endstop_state { get; }

            public C_config config { get; }

            public static C_min_endstop Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_min_endstop(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.min_endstop.endstop_state"), C_config.Construct(_comm));
            }

            public partial class C_config
            {
                public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> gpio_num, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> offset, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> is_active_high, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> debounce_ms)
                {
                    this.gpio_num = gpio_num;
                    this.enabled = enabled;
                    this.offset = offset;
                    this.is_active_high = is_active_high;
                    this.debounce_ms = debounce_ms;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> gpio_num { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> offset { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> is_active_high { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> debounce_ms { get; }

                public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt16>(_comm, "axis0.min_endstop.config.gpio_num"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.min_endstop.config.enabled"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.min_endstop.config.offset"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.min_endstop.config.is_active_high"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.min_endstop.config.debounce_ms"));
                }
            }
        }

        public partial class C_max_endstop
        {
            public C_max_endstop(FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> endstop_state, C_config config)
            {
                this.endstop_state = endstop_state;
                this.config = config;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> endstop_state { get; }

            public C_config config { get; }

            public static C_max_endstop Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_max_endstop(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.max_endstop.endstop_state"), C_config.Construct(_comm));
            }

            public partial class C_config
            {
                public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> gpio_num, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> offset, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> is_active_high, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> debounce_ms)
                {
                    this.gpio_num = gpio_num;
                    this.enabled = enabled;
                    this.offset = offset;
                    this.is_active_high = is_active_high;
                    this.debounce_ms = debounce_ms;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> gpio_num { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> offset { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> is_active_high { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> debounce_ms { get; }

                public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt16>(_comm, "axis0.max_endstop.config.gpio_num"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.max_endstop.config.enabled"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.max_endstop.config.offset"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.max_endstop.config.is_active_high"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.max_endstop.config.debounce_ms"));
                }
            }
        }

        public partial class C_mechanical_brake
        {
            public C_mechanical_brake(C_config config, F_engage engage, F_release release)
            {
                this.config = config;
                this.engage = engage;
                this.release = release;
            }

            public C_config config { get; }

            public F_engage engage { get; }

            public F_release release { get; }

            public static C_mechanical_brake Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_mechanical_brake(C_config.Construct(_comm), F_engage.Construct(_comm), F_release.Construct(_comm));
            }

            public partial class C_config
            {
                public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> gpio_num, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> is_active_low)
                {
                    this.gpio_num = gpio_num;
                    this.is_active_low = is_active_low;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt16> gpio_num { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> is_active_low { get; }

                public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt16>(_comm, "axis0.mechanical_brake.config.gpio_num"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.mechanical_brake.config.is_active_low"));
                }
            }

            public class F_engage
            {
                private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
                FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
                public async System.Threading.Tasks.Task InvokeAsync()
                {
                    await this._invoker.CallAsync();
                }

                F_engage(FibreSharp.HighLevel.ICallInvoker _invoker)
                {
                    this._invoker = _invoker;
                }

                public static F_engage Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new F_engage(FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "axis0.mechanical_brake.engage"));
                }
            }

            public class F_release
            {
                private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
                FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
                public async System.Threading.Tasks.Task InvokeAsync()
                {
                    await this._invoker.CallAsync();
                }

                F_release(FibreSharp.HighLevel.ICallInvoker _invoker)
                {
                    this._invoker = _invoker;
                }

                public static F_release Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new F_release(FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "axis0.mechanical_brake.release"));
                }
            }
        }

        public partial class C_pos_vel_mapper
        {
            public C_pos_vel_mapper(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_rel, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_abs, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vel, C_config config)
            {
                this.status = status;
                this.pos_rel = pos_rel;
                this.pos_abs = pos_abs;
                this.vel = vel;
                this.config = config;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_rel { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_abs { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vel { get; }

            public C_config config { get; }

            public static C_pos_vel_mapper Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_pos_vel_mapper(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.pos_vel_mapper.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.pos_vel_mapper.pos_rel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.pos_vel_mapper.pos_abs"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.pos_vel_mapper.vel"), C_config.Construct(_comm));
            }

            public partial class C_config
            {
                public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> circular, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> circular_output_range, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> scale, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> offset_valid, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> offset, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> index_offset_valid, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> index_offset, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> use_index_gpio, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> index_search_always_on, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> index_gpio, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> use_endstop)
                {
                    this.circular = circular;
                    this.circular_output_range = circular_output_range;
                    this.scale = scale;
                    this.offset_valid = offset_valid;
                    this.offset = offset;
                    this.index_offset_valid = index_offset_valid;
                    this.index_offset = index_offset;
                    this.use_index_gpio = use_index_gpio;
                    this.index_search_always_on = index_search_always_on;
                    this.index_gpio = index_gpio;
                    this.use_endstop = use_endstop;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> circular { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> circular_output_range { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> scale { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> offset_valid { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> offset { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> index_offset_valid { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> index_offset { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> use_index_gpio { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> index_search_always_on { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> index_gpio { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> use_endstop { get; }

                public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.pos_vel_mapper.config.circular"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.pos_vel_mapper.config.circular_output_range"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.pos_vel_mapper.config.scale"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.pos_vel_mapper.config.offset_valid"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.pos_vel_mapper.config.offset"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.pos_vel_mapper.config.index_offset_valid"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.pos_vel_mapper.config.index_offset"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.pos_vel_mapper.config.use_index_gpio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.pos_vel_mapper.config.index_search_always_on"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.pos_vel_mapper.config.index_gpio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.pos_vel_mapper.config.use_endstop"));
                }
            }
        }

        public partial class C_commutation_mapper
        {
            public C_commutation_mapper(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_rel, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_abs, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vel, C_config config)
            {
                this.status = status;
                this.pos_rel = pos_rel;
                this.pos_abs = pos_abs;
                this.vel = vel;
                this.config = config;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_rel { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_abs { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vel { get; }

            public C_config config { get; }

            public static C_commutation_mapper Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_commutation_mapper(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.commutation_mapper.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.commutation_mapper.pos_rel"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.commutation_mapper.pos_abs"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.commutation_mapper.vel"), C_config.Construct(_comm));
            }

            public partial class C_config
            {
                public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> circular, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> circular_output_range, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> scale, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> offset_valid, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> offset, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> index_offset_valid, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> index_offset, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> use_index_gpio, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> index_search_always_on, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> index_gpio, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> use_endstop)
                {
                    this.circular = circular;
                    this.circular_output_range = circular_output_range;
                    this.scale = scale;
                    this.offset_valid = offset_valid;
                    this.offset = offset;
                    this.index_offset_valid = index_offset_valid;
                    this.index_offset = index_offset;
                    this.use_index_gpio = use_index_gpio;
                    this.index_search_always_on = index_search_always_on;
                    this.index_gpio = index_gpio;
                    this.use_endstop = use_endstop;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> circular { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> circular_output_range { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> scale { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> offset_valid { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> offset { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> index_offset_valid { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> index_offset { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> use_index_gpio { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> index_search_always_on { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> index_gpio { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> use_endstop { get; }

                public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.commutation_mapper.config.circular"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.commutation_mapper.config.circular_output_range"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.commutation_mapper.config.scale"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.commutation_mapper.config.offset_valid"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.commutation_mapper.config.offset"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.commutation_mapper.config.index_offset_valid"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.commutation_mapper.config.index_offset"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.commutation_mapper.config.use_index_gpio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.commutation_mapper.config.index_search_always_on"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.commutation_mapper.config.index_gpio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.commutation_mapper.config.use_endstop"));
                }
            }
        }

        public partial class C_interpolator
        {
            public C_interpolator(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> interpolation, C_config config)
            {
                this.status = status;
                this.interpolation = interpolation;
                this.config = config;
            }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> interpolation { get; }

            public C_config config { get; }

            public static C_interpolator Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_interpolator(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "axis0.interpolator.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.interpolator.interpolation"), C_config.Construct(_comm));
            }

            public partial class C_config
            {
                public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> dynamic)
                {
                    this.dynamic = dynamic;
                }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> dynamic { get; }

                public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "axis0.interpolator.config.dynamic"));
                }
            }
        }

        public partial class C_task_times
        {
            public C_task_times(C_thermistor_update thermistor_update, C_sensorless_estimator_update sensorless_estimator_update, C_endstop_update endstop_update, C_can_heartbeat can_heartbeat, C_controller_update controller_update, C_open_loop_vector_generator_update open_loop_vector_generator_update, C_acim_estimator_update acim_estimator_update, C_motor_update motor_update, C_current_controller_update current_controller_update, C_current_sense current_sense, C_pwm_update pwm_update)
            {
                this.thermistor_update = thermistor_update;
                this.sensorless_estimator_update = sensorless_estimator_update;
                this.endstop_update = endstop_update;
                this.can_heartbeat = can_heartbeat;
                this.controller_update = controller_update;
                this.open_loop_vector_generator_update = open_loop_vector_generator_update;
                this.acim_estimator_update = acim_estimator_update;
                this.motor_update = motor_update;
                this.current_controller_update = current_controller_update;
                this.current_sense = current_sense;
                this.pwm_update = pwm_update;
            }

            public C_thermistor_update thermistor_update { get; }

            public C_sensorless_estimator_update sensorless_estimator_update { get; }

            public C_endstop_update endstop_update { get; }

            public C_can_heartbeat can_heartbeat { get; }

            public C_controller_update controller_update { get; }

            public C_open_loop_vector_generator_update open_loop_vector_generator_update { get; }

            public C_acim_estimator_update acim_estimator_update { get; }

            public C_motor_update motor_update { get; }

            public C_current_controller_update current_controller_update { get; }

            public C_current_sense current_sense { get; }

            public C_pwm_update pwm_update { get; }

            public static C_task_times Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_task_times(C_thermistor_update.Construct(_comm), C_sensorless_estimator_update.Construct(_comm), C_endstop_update.Construct(_comm), C_can_heartbeat.Construct(_comm), C_controller_update.Construct(_comm), C_open_loop_vector_generator_update.Construct(_comm), C_acim_estimator_update.Construct(_comm), C_motor_update.Construct(_comm), C_current_controller_update.Construct(_comm), C_current_sense.Construct(_comm), C_pwm_update.Construct(_comm));
            }

            public partial class C_thermistor_update
            {
                public C_thermistor_update(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_thermistor_update Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_thermistor_update(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.thermistor_update.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.thermistor_update.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.thermistor_update.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.thermistor_update.max_length"));
                }
            }

            public partial class C_sensorless_estimator_update
            {
                public C_sensorless_estimator_update(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_sensorless_estimator_update Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_sensorless_estimator_update(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.sensorless_estimator_update.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.sensorless_estimator_update.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.sensorless_estimator_update.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.sensorless_estimator_update.max_length"));
                }
            }

            public partial class C_endstop_update
            {
                public C_endstop_update(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_endstop_update Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_endstop_update(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.endstop_update.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.endstop_update.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.endstop_update.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.endstop_update.max_length"));
                }
            }

            public partial class C_can_heartbeat
            {
                public C_can_heartbeat(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_can_heartbeat Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_can_heartbeat(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.can_heartbeat.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.can_heartbeat.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.can_heartbeat.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.can_heartbeat.max_length"));
                }
            }

            public partial class C_controller_update
            {
                public C_controller_update(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_controller_update Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_controller_update(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.controller_update.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.controller_update.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.controller_update.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.controller_update.max_length"));
                }
            }

            public partial class C_open_loop_vector_generator_update
            {
                public C_open_loop_vector_generator_update(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_open_loop_vector_generator_update Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_open_loop_vector_generator_update(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.open_loop_vector_generator_update.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.open_loop_vector_generator_update.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.open_loop_vector_generator_update.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.open_loop_vector_generator_update.max_length"));
                }
            }

            public partial class C_acim_estimator_update
            {
                public C_acim_estimator_update(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_acim_estimator_update Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_acim_estimator_update(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.acim_estimator_update.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.acim_estimator_update.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.acim_estimator_update.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.acim_estimator_update.max_length"));
                }
            }

            public partial class C_motor_update
            {
                public C_motor_update(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_motor_update Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_motor_update(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.motor_update.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.motor_update.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.motor_update.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.motor_update.max_length"));
                }
            }

            public partial class C_current_controller_update
            {
                public C_current_controller_update(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_current_controller_update Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_current_controller_update(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.current_controller_update.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.current_controller_update.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.current_controller_update.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.current_controller_update.max_length"));
                }
            }

            public partial class C_current_sense
            {
                public C_current_sense(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_current_sense Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_current_sense(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.current_sense.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.current_sense.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.current_sense.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.current_sense.max_length"));
                }
            }

            public partial class C_pwm_update
            {
                public C_pwm_update(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length)
                {
                    this.start_time = start_time;
                    this.end_time = end_time;
                    this.length = length;
                    this.max_length = max_length;
                }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> start_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> end_time { get; }

                public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> length { get; }

                public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> max_length { get; }

                public static C_pwm_update Construct(FibreSharp.ILegacyFibreClient _comm)
                {
                    return new C_pwm_update(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.pwm_update.start_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.pwm_update.end_time"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.pwm_update.length"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "axis0.task_times.pwm_update.max_length"));
                }
            }
        }

        public class F_watchdog_feed
        {
            private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
            FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
            public async System.Threading.Tasks.Task InvokeAsync()
            {
                await this._invoker.CallAsync();
            }

            F_watchdog_feed(FibreSharp.HighLevel.ICallInvoker _invoker)
            {
                this._invoker = _invoker;
            }

            public static F_watchdog_feed Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new F_watchdog_feed(FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "axis0.watchdog_feed"));
            }
        }

        public class F_set_abs_pos
        {
            public FibreSharp.HighLevel.IWriteScalarAccessor<System.Single> pos { get; }

            public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> delta_pos_ref { get; }

            private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
            FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
            public async System.Threading.Tasks.Task<System.Single> InvokeAsync(System.Single pos)
            {
                await this.pos.SetAsync(pos);
                await this._invoker.CallAsync();
                return await this.delta_pos_ref.GetAsync();
            }

            F_set_abs_pos(FibreSharp.HighLevel.IWriteScalarAccessor<System.Single> pos, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> delta_pos_ref, FibreSharp.HighLevel.ICallInvoker _invoker)
            {
                this.pos = pos;
                this.delta_pos_ref = delta_pos_ref;
                this._invoker = _invoker;
            }

            public static F_set_abs_pos Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new F_set_abs_pos(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.set_abs_pos.pos"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "axis0.set_abs_pos.delta_pos_ref"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "axis0.set_abs_pos"));
            }
        }
    }

    public partial class C_onboard_encoder0
    {
        public C_onboard_encoder0(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> raw)
        {
            this.status = status;
            this.raw = raw;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> raw { get; }

        public static C_onboard_encoder0 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_onboard_encoder0(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "onboard_encoder0.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "onboard_encoder0.raw"));
        }
    }

    public partial class C_inc_encoder0
    {
        public C_inc_encoder0(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_min, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_max, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_residual, C_config config)
        {
            this.status = status;
            this.pos_min = pos_min;
            this.pos_max = pos_max;
            this.pos_residual = pos_residual;
            this.config = config;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_min { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_max { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_residual { get; }

        public C_config config { get; }

        public static C_inc_encoder0 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_inc_encoder0(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "inc_encoder0.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "inc_encoder0.pos_min"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "inc_encoder0.pos_max"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "inc_encoder0.pos_residual"), C_config.Construct(_comm));
        }

        public partial class C_config
        {
            public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> cpr)
            {
                this.enabled = enabled;
                this.cpr = cpr;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> cpr { get; }

            public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "inc_encoder0.config.enabled"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "inc_encoder0.config.cpr"));
            }
        }
    }

    public partial class C_inc_encoder1
    {
        public C_inc_encoder1(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_min, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_max, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_residual, C_config config)
        {
            this.status = status;
            this.pos_min = pos_min;
            this.pos_max = pos_max;
            this.pos_residual = pos_residual;
            this.config = config;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_min { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_max { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_residual { get; }

        public C_config config { get; }

        public static C_inc_encoder1 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_inc_encoder1(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "inc_encoder1.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "inc_encoder1.pos_min"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "inc_encoder1.pos_max"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "inc_encoder1.pos_residual"), C_config.Construct(_comm));
        }

        public partial class C_config
        {
            public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> cpr)
            {
                this.enabled = enabled;
                this.cpr = cpr;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.UInt32> cpr { get; }

            public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "inc_encoder1.config.enabled"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "inc_encoder1.config.cpr"));
            }
        }
    }

    public partial class C_hall_encoder0
    {
        public C_hall_encoder0(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> hall_cnt, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> raw_hall_state, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> abs_pos_min, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> abs_pos_max, C_config config)
        {
            this.status = status;
            this.hall_cnt = hall_cnt;
            this.raw_hall_state = raw_hall_state;
            this.abs_pos_min = abs_pos_min;
            this.abs_pos_max = abs_pos_max;
            this.config = config;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> hall_cnt { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> raw_hall_state { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> abs_pos_min { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> abs_pos_max { get; }

        public C_config config { get; }

        public static C_hall_encoder0 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_hall_encoder0(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hall_encoder0.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hall_encoder0.hall_cnt"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hall_encoder0.raw_hall_state"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "hall_encoder0.abs_pos_min"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "hall_encoder0.abs_pos_max"), C_config.Construct(_comm));
        }

        public partial class C_config
        {
            public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> hall_polarity, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> hall_polarity_calibrated, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> ignore_illegal_hall_state)
            {
                this.enabled = enabled;
                this.hall_polarity = hall_polarity;
                this.hall_polarity_calibrated = hall_polarity_calibrated;
                this.ignore_illegal_hall_state = ignore_illegal_hall_state;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> hall_polarity { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> hall_polarity_calibrated { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> ignore_illegal_hall_state { get; }

            public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "hall_encoder0.config.enabled"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hall_encoder0.config.hall_polarity"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "hall_encoder0.config.hall_polarity_calibrated"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "hall_encoder0.config.ignore_illegal_hall_state"));
            }
        }
    }

    public partial class C_hall_encoder1
    {
        public C_hall_encoder1(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> hall_cnt, FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> raw_hall_state, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> abs_pos_min, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> abs_pos_max, C_config config)
        {
            this.status = status;
            this.hall_cnt = hall_cnt;
            this.raw_hall_state = raw_hall_state;
            this.abs_pos_min = abs_pos_min;
            this.abs_pos_max = abs_pos_max;
            this.config = config;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> hall_cnt { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> raw_hall_state { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> abs_pos_min { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> abs_pos_max { get; }

        public C_config config { get; }

        public static C_hall_encoder1 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_hall_encoder1(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hall_encoder1.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hall_encoder1.hall_cnt"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hall_encoder1.raw_hall_state"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "hall_encoder1.abs_pos_min"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "hall_encoder1.abs_pos_max"), C_config.Construct(_comm));
        }

        public partial class C_config
        {
            public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> hall_polarity, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> hall_polarity_calibrated, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> ignore_illegal_hall_state)
            {
                this.enabled = enabled;
                this.hall_polarity = hall_polarity;
                this.hall_polarity_calibrated = hall_polarity_calibrated;
                this.ignore_illegal_hall_state = ignore_illegal_hall_state;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> enabled { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> hall_polarity { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> hall_polarity_calibrated { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Boolean> ignore_illegal_hall_state { get; }

            public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "hall_encoder1.config.enabled"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "hall_encoder1.config.hall_polarity"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "hall_encoder1.config.hall_polarity_calibrated"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "hall_encoder1.config.ignore_illegal_hall_state"));
            }
        }
    }

    public partial class C_spi_encoder0
    {
        public C_spi_encoder0(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> raw, C_config config)
        {
            this.status = status;
            this.raw = raw;
            this.config = config;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> raw { get; }

        public C_config config { get; }

        public static C_spi_encoder0 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_spi_encoder0(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "spi_encoder0.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "spi_encoder0.raw"), C_config.Construct(_comm));
        }

        public partial class C_config
        {
            public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> ncs_gpio, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> delay)
            {
                this.ncs_gpio = ncs_gpio;
                this.mode = mode;
                this.delay = delay;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> ncs_gpio { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> mode { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> delay { get; }

            public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "spi_encoder0.config.ncs_gpio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "spi_encoder0.config.mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "spi_encoder0.config.delay"));
            }
        }
    }

    public partial class C_spi_encoder1
    {
        public C_spi_encoder1(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> raw, C_config config)
        {
            this.status = status;
            this.raw = raw;
            this.config = config;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> raw { get; }

        public C_config config { get; }

        public static C_spi_encoder1 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_spi_encoder1(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "spi_encoder1.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "spi_encoder1.raw"), C_config.Construct(_comm));
        }

        public partial class C_config
        {
            public C_config(FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> ncs_gpio, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> mode, FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> delay)
            {
                this.ncs_gpio = ncs_gpio;
                this.mode = mode;
                this.delay = delay;
            }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> ncs_gpio { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Byte> mode { get; }

            public FibreSharp.HighLevel.IReadWriteScalarAccessor<System.Single> delay { get; }

            public static C_config Construct(FibreSharp.ILegacyFibreClient _comm)
            {
                return new C_config(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "spi_encoder1.config.ncs_gpio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "spi_encoder1.config.mode"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "spi_encoder1.config.delay"));
            }
        }
    }

    public partial class C_encoder_estimator0
    {
        public C_encoder_estimator0(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_estimate, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vel_estimate)
        {
            this.status = status;
            this.pos_estimate = pos_estimate;
            this.vel_estimate = vel_estimate;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_estimate { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vel_estimate { get; }

        public static C_encoder_estimator0 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_encoder_estimator0(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "encoder_estimator0.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "encoder_estimator0.pos_estimate"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "encoder_estimator0.vel_estimate"));
        }
    }

    public partial class C_encoder_estimator1
    {
        public C_encoder_estimator1(FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_estimate, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vel_estimate)
        {
            this.status = status;
            this.pos_estimate = pos_estimate;
            this.vel_estimate = vel_estimate;
        }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Byte> status { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> pos_estimate { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> vel_estimate { get; }

        public static C_encoder_estimator1 Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new C_encoder_estimator1(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "encoder_estimator1.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "encoder_estimator1.pos_estimate"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "encoder_estimator1.vel_estimate"));
        }
    }

    public class F_test_function
    {
        public FibreSharp.HighLevel.IWriteScalarAccessor<System.Int32> delta { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> cnt { get; }

        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task<System.Int32> InvokeAsync(System.Int32 delta)
        {
            await this.delta.SetAsync(delta);
            await this._invoker.CallAsync();
            return await this.cnt.GetAsync();
        }

        F_test_function(FibreSharp.HighLevel.IWriteScalarAccessor<System.Int32> delta, FibreSharp.HighLevel.IReadScalarAccessor<System.Int32> cnt, FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this.delta = delta;
            this.cnt = cnt;
            this._invoker = _invoker;
        }

        public static F_test_function Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_test_function(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Int32>(_comm, "test_function.delta"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Int32>(_comm, "test_function.cnt"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "test_function"));
        }
    }

    public class F_get_adc_voltage
    {
        public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> gpio { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Single> voltage { get; }

        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task<System.Single> InvokeAsync(System.UInt32 gpio)
        {
            await this.gpio.SetAsync(gpio);
            await this._invoker.CallAsync();
            return await this.voltage.GetAsync();
        }

        F_get_adc_voltage(FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> gpio, FibreSharp.HighLevel.IReadScalarAccessor<System.Single> voltage, FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this.gpio = gpio;
            this.voltage = voltage;
            this._invoker = _invoker;
        }

        public static F_get_adc_voltage Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_get_adc_voltage(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "get_adc_voltage.gpio"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Single>(_comm, "get_adc_voltage.voltage"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "get_adc_voltage"));
        }
    }

    public class F_save_configuration
    {
        public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> success { get; }

        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task<System.Boolean> InvokeAsync()
        {
            await this._invoker.CallAsync();
            return await this.success.GetAsync();
        }

        F_save_configuration(FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> success, FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this.success = success;
            this._invoker = _invoker;
        }

        public static F_save_configuration Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_save_configuration(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "save_configuration.success"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "save_configuration"));
        }
    }

    public class F_erase_configuration
    {
        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task InvokeAsync()
        {
            await this._invoker.CallAsync();
        }

        F_erase_configuration(FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this._invoker = _invoker;
        }

        public static F_erase_configuration Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_erase_configuration(FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "erase_configuration"));
        }
    }

    public class F_reboot
    {
        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task InvokeAsync()
        {
            await this._invoker.CallAsync();
        }

        F_reboot(FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this._invoker = _invoker;
        }

        public static F_reboot Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_reboot(FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "reboot"));
        }
    }

    public class F_enter_dfu_mode
    {
        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task InvokeAsync()
        {
            await this._invoker.CallAsync();
        }

        F_enter_dfu_mode(FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this._invoker = _invoker;
        }

        public static F_enter_dfu_mode Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_enter_dfu_mode(FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "enter_dfu_mode"));
        }
    }

    public class F_get_interrupt_status
    {
        public FibreSharp.HighLevel.IWriteScalarAccessor<System.Int32> irqn { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> status { get; }

        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task<System.UInt32> InvokeAsync(System.Int32 irqn)
        {
            await this.irqn.SetAsync(irqn);
            await this._invoker.CallAsync();
            return await this.status.GetAsync();
        }

        F_get_interrupt_status(FibreSharp.HighLevel.IWriteScalarAccessor<System.Int32> irqn, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> status, FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this.irqn = irqn;
            this.status = status;
            this._invoker = _invoker;
        }

        public static F_get_interrupt_status Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_get_interrupt_status(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Int32>(_comm, "get_interrupt_status.irqn"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "get_interrupt_status.status"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "get_interrupt_status"));
        }
    }

    public class F_get_dma_status
    {
        public FibreSharp.HighLevel.IWriteScalarAccessor<System.Byte> stream_num { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> status { get; }

        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task<System.UInt32> InvokeAsync(System.Byte stream_num)
        {
            await this.stream_num.SetAsync(stream_num);
            await this._invoker.CallAsync();
            return await this.status.GetAsync();
        }

        F_get_dma_status(FibreSharp.HighLevel.IWriteScalarAccessor<System.Byte> stream_num, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> status, FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this.stream_num = stream_num;
            this.status = status;
            this._invoker = _invoker;
        }

        public static F_get_dma_status Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_get_dma_status(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Byte>(_comm, "get_dma_status.stream_num"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "get_dma_status.status"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "get_dma_status"));
        }
    }

    public class F_get_gpio_states
    {
        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> status { get; }

        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task<System.UInt32> InvokeAsync()
        {
            await this._invoker.CallAsync();
            return await this.status.GetAsync();
        }

        F_get_gpio_states(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> status, FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this.status = status;
            this._invoker = _invoker;
        }

        public static F_get_gpio_states Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_get_gpio_states(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "get_gpio_states.status"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "get_gpio_states"));
        }
    }

    public class F_set_gpio
    {
        public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> num { get; }

        public FibreSharp.HighLevel.IWriteScalarAccessor<System.Boolean> status { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> ok { get; }

        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task<System.Boolean> InvokeAsync(System.UInt32 num, System.Boolean status)
        {
            await this.num.SetAsync(num);
            await this.status.SetAsync(status);
            await this._invoker.CallAsync();
            return await this.ok.GetAsync();
        }

        F_set_gpio(FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> num, FibreSharp.HighLevel.IWriteScalarAccessor<System.Boolean> status, FibreSharp.HighLevel.IReadScalarAccessor<System.Boolean> ok, FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this.num = num;
            this.status = status;
            this.ok = ok;
            this._invoker = _invoker;
        }

        public static F_set_gpio Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_set_gpio(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "set_gpio.num"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "set_gpio.status"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.Boolean>(_comm, "set_gpio.ok"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "set_gpio"));
        }
    }

    public class F_get_drv_fault
    {
        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> drv_fault { get; }

        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task<System.UInt64> InvokeAsync()
        {
            await this._invoker.CallAsync();
            return await this.drv_fault.GetAsync();
        }

        F_get_drv_fault(FibreSharp.HighLevel.IReadScalarAccessor<System.UInt64> drv_fault, FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this.drv_fault = drv_fault;
            this._invoker = _invoker;
        }

        public static F_get_drv_fault Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_get_drv_fault(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt64>(_comm, "get_drv_fault.drv_fault"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "get_drv_fault"));
        }
    }

    public class F_clear_errors
    {
        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task InvokeAsync()
        {
            await this._invoker.CallAsync();
        }

        F_clear_errors(FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this._invoker = _invoker;
        }

        public static F_clear_errors Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_clear_errors(FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "clear_errors"));
        }
    }

    public class F_get_raw
    {
        public FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> address { get; }

        public FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> value { get; }

        private readonly FibreSharp.HighLevel.ICallInvoker _invoker;
        FibreSharp.LegacyManifestParser.FunctionEndpoint Endpoint => this._invoker.Endpoint;
        public async System.Threading.Tasks.Task<System.UInt32> InvokeAsync(System.UInt32 address)
        {
            await this.address.SetAsync(address);
            await this._invoker.CallAsync();
            return await this.value.GetAsync();
        }

        F_get_raw(FibreSharp.HighLevel.IWriteScalarAccessor<System.UInt32> address, FibreSharp.HighLevel.IReadScalarAccessor<System.UInt32> value, FibreSharp.HighLevel.ICallInvoker _invoker)
        {
            this.address = address;
            this.value = value;
            this._invoker = _invoker;
        }

        public static F_get_raw Construct(FibreSharp.ILegacyFibreClient _comm)
        {
            return new F_get_raw(FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "get_raw.address"), FibreSharp.HighLevel.HighLevelHelper.GetAccessor<System.UInt32>(_comm, "get_raw.value"), FibreSharp.HighLevel.HighLevelHelper.GetCaller(_comm, "get_raw"));
        }
    }
}

public enum ArmedState
{
    DISARMED = 0x0,
    WAITING_FOR_TIMINGS = 0x1,
    WAITING_FOR_UPDATE = 0x2,
    ARMED = 0x3
}

[System.FlagsAttribute]
public enum AxisError
{
    NONE = 0x0,
    INVALID_STATE = 0x1,
    WATCHDOG_TIMER_EXPIRED = 0x800,
    MIN_ENDSTOP_PRESSED = 0x1000,
    MAX_ENDSTOP_PRESSED = 0x2000,
    ESTOP_REQUESTED = 0x4000,
    HOMING_WITHOUT_ENDSTOP = 0x20000,
    OVER_TEMP = 0x40000,
    UNKNOWN_POSITION = 0x80000,
    DC_BUS_UNDER_VOLTAGE = 0x2,
    DC_BUS_OVER_VOLTAGE = 0x4,
    CURRENT_MEASUREMENT_TIMEOUT = 0x8,
    BRAKE_RESISTOR_DISARMED = 0x10,
    MOTOR_DISARMED = 0x20,
    MOTOR_FAILED = 0x40,
    SENSORLESS_ESTIMATOR_FAILED = 0x80,
    ENCODER_FAILED = 0x100,
    CONTROLLER_FAILED = 0x200,
    POS_CTRL_DURING_SENSORLESS = 0x400
}

[System.FlagsAttribute]
public enum AxisState
{
    UNDEFINED = 0x0,
    IDLE = 0x1,
    STARTUP_SEQUENCE = 0x2,
    FULL_CALIBRATION_SEQUENCE = 0x3,
    MOTOR_CALIBRATION = 0x4,
    ENCODER_INDEX_SEARCH = 0x6,
    ENCODER_OFFSET_CALIBRATION = 0x7,
    CLOSED_LOOP_CONTROL = 0x8,
    LOCKIN_SPIN = 0x9,
    ENCODER_DIR_FIND = 0xA,
    HOMING = 0xB,
    ENCODER_HALL_POLARITY_CALIBRATION = 0xC,
    ENCODER_HALL_PHASE_CALIBRATION = 0xD,
    SENSORLESS_CONTROL = 0x5
}

[System.FlagsAttribute]
public enum CanError
{
    NONE = 0x0,
    DUPLICATE_CAN_IDS = 0x1
}

public enum ComponentStatus
{
    NOMINAL = 0x0,
    NO_RESPONSE = 0x1,
    INVALID_RESPONSE_LENGTH = 0x2,
    PARITY_MISMATCH = 0x3,
    ILLEGAL_HALL_STATE = 0x4,
    POLARITY_NOT_CALIBRATED = 0x5,
    PHASES_NOT_CALIBRATED = 0x6,
    NUMERICAL_ERROR = 0x7,
    MISSING_INPUT = 0x8,
    RELATIVE_MODE = 0x9,
    UNCONFIGURED = 0xA,
    OVERSPEED = 0xB,
    INDEX_NOT_FOUND = 0xC,
    BAD_CONFIG = 0xD,
    NOT_ENABLED = 0xE,
    SPINOUT_DETECTED = 0xF
}

[System.FlagsAttribute]
public enum ControlMode
{
    VOLTAGE_CONTROL = 0x0,
    TORQUE_CONTROL = 0x1,
    VELOCITY_CONTROL = 0x2,
    POSITION_CONTROL = 0x3,
    TRAJECTORY_CONTROL = 0x4
}

[System.FlagsAttribute]
public enum ControllerError
{
    NONE = 0x0,
    OVERSPEED = 0x1,
    INVALID_INPUT_MODE = 0x2,
    UNSTABLE_GAIN = 0x4,
    INVALID_MIRROR_AXIS = 0x8,
    INVALID_LOAD_ENCODER = 0x10,
    INVALID_ESTIMATE = 0x20,
    INVALID_CIRCULAR_RANGE = 0x40,
    SPINOUT_DETECTED = 0x80
}

[System.FlagsAttribute]
public enum DrvFault
{
    NO_FAULT = 0x0,
    FET_LOW_C_OVERCURRENT = 0x1,
    FET_HIGH_C_OVERCURRENT = 0x2,
    FET_LOW_B_OVERCURRENT = 0x4,
    FET_HIGH_B_OVERCURRENT = 0x8,
    FET_LOW_A_OVERCURRENT = 0x10,
    FET_HIGH_A_OVERCURRENT = 0x20,
    OVERTEMPERATURE_WARNING = 0x40,
    OVERTEMPERATURE_SHUTDOWN = 0x80,
    P_VDD_UNDERVOLTAGE = 0x100,
    G_VDD_UNDERVOLTAGE = 0x200,
    G_VDD_OVERVOLTAGE = 0x400
}

[System.FlagsAttribute]
public enum EncoderError
{
    NONE = 0x0,
    UNSTABLE_GAIN = 0x1,
    CPR_POLEPAIRS_MISMATCH = 0x2,
    NO_RESPONSE = 0x4,
    UNSUPPORTED_ENCODER_MODE = 0x8,
    ILLEGAL_HALL_STATE = 0x10,
    INDEX_NOT_FOUND_YET = 0x20,
    ABS_SPI_TIMEOUT = 0x40,
    ABS_SPI_COM_FAIL = 0x80,
    ABS_SPI_NOT_READY = 0x100,
    HALL_NOT_CALIBRATED_YET = 0x200
}

public enum EncoderId
{
    NONE = 0x0,
    INC_ENCODER0 = 0x1,
    INC_ENCODER1 = 0x2,
    INC_ENCODER2 = 0x3,
    SENSORLESS_ESTIMATOR = 0x4,
    SPI_ENCODER0 = 0x5,
    SPI_ENCODER1 = 0x6,
    SPI_ENCODER2 = 0x7,
    HALL_ENCODER0 = 0x8,
    HALL_ENCODER1 = 0x9,
    AMT21_ENCODER0 = 0xA,
    AMT21_ENCODER1 = 0xB,
    AMT21_ENCODER2 = 0xC,
    ONBOARD_ENCODER0 = 0xD,
    ONBOARD_ENCODER1 = 0xE
}

public enum EncoderMode
{
    INCREMENTAL = 0x0,
    HALL = 0x1,
    SINCOS = 0x2,
    SPI_ABS_CUI = 0x100,
    SPI_ABS_AMS = 0x101,
    SPI_ABS_AEAT = 0x102,
    SPI_ABS_RLS = 0x103,
    SPI_ABS_MA732 = 0x104
}

public enum GpioMode
{
    DIGITAL = 0x0,
    DIGITAL_PULL_UP = 0x1,
    DIGITAL_PULL_DOWN = 0x2,
    ANALOG_IN = 0x3,
    UART_A = 0x4,
    UART_B = 0x5,
    UART_C = 0x6,
    CAN_A = 0x7,
    I2C_A = 0x8,
    SPI_A = 0x9,
    PWM = 0xA,
    ENC0 = 0xB,
    ENC1 = 0xC,
    ENC2 = 0xD,
    MECH_BRAKE = 0xE,
    STATUS = 0xF,
    BRAKE_RES = 0x10,
    AUTO = 0x11
}

public enum InputMode
{
    INACTIVE = 0x0,
    PASSTHROUGH = 0x1,
    VEL_RAMP = 0x2,
    POS_FILTER = 0x3,
    MIX_CHANNELS = 0x4,
    TRAP_TRAJ = 0x5,
    TORQUE_RAMP = 0x6,
    MIRROR = 0x7,
    TUNING = 0x8
}

[System.FlagsAttribute]
public enum LegacyODriveError
{
    NONE = 0x0,
    CONTROL_ITERATION_MISSED = 0x1,
    DC_BUS_UNDER_VOLTAGE = 0x2,
    DC_BUS_OVER_VOLTAGE = 0x4,
    DC_BUS_OVER_REGEN_CURRENT = 0x8,
    DC_BUS_OVER_CURRENT = 0x10,
    BRAKE_DEADTIME_VIOLATION = 0x20,
    BRAKE_DUTY_CYCLE_NAN = 0x40,
    INVALID_BRAKE_RESISTANCE = 0x80
}

public enum LockinState
{
    INACTIVE = 0x0,
    RAMP = 0x1,
    ACCELERATE = 0x2,
    CONST_VEL = 0x3
}

[System.FlagsAttribute]
public enum MotorError : ulong
{
    NONE = 0x0,
    DRV_FAULT = 0x8,
    CONTROL_DEADLINE_MISSED = 0x10,
    MODULATION_MAGNITUDE = 0x80,
    CURRENT_SENSE_SATURATION = 0x400,
    CURRENT_LIMIT_VIOLATION = 0x1000,
    MODULATION_IS_NAN = 0x10000,
    MOTOR_THERMISTOR_OVER_TEMP = 0x20000,
    FET_THERMISTOR_OVER_TEMP = 0x40000,
    TIMER_UPDATE_MISSED = 0x80000,
    CURRENT_MEASUREMENT_UNAVAILABLE = 0x100000,
    CONTROLLER_FAILED = 0x200000,
    I_BUS_OUT_OF_RANGE = 0x400000,
    BRAKE_RESISTOR_DISARMED = 0x800000,
    SYSTEM_LEVEL = 0x1000000,
    BAD_TIMING = 0x2000000,
    UNKNOWN_PHASE_ESTIMATE = 0x4000000,
    UNKNOWN_PHASE_VEL = 0x8000000,
    UNKNOWN_TORQUE = 0x10000000,
    UNKNOWN_CURRENT_COMMAND = 0x20000000,
    UNKNOWN_CURRENT_MEASUREMENT = 0x40000000,
    UNKNOWN_VBUS_VOLTAGE = 0x80000000,
    UNKNOWN_VOLTAGE_COMMAND = 0x100000000,
    UNKNOWN_GAINS = 0x200000000,
    OPAMP_DISABLED = 0x800000000,
    DC_CALIB_IN_PROGRESS = 0x1000000000,
    DC_CALIB_OUT_OF_RANGE = 0x2000000000,
    PHASE_RESISTANCE_OUT_OF_RANGE = 0x1,
    PHASE_INDUCTANCE_OUT_OF_RANGE = 0x2,
    ADC_FAILED = 0x4,
    NOT_IMPLEMENTED_MOTOR_TYPE = 0x20,
    BRAKE_CURRENT_OUT_OF_RANGE = 0x40,
    BRAKE_DEADTIME_VIOLATION = 0x100,
    UNEXPECTED_TIMER_CALLBACK = 0x200,
    BRAKE_DUTY_CYCLE_NAN = 0x2000,
    DC_BUS_OVER_REGEN_CURRENT = 0x4000,
    DC_BUS_OVER_CURRENT = 0x8000
}

public enum MotorType
{
    HIGH_CURRENT = 0x0,
    GIMBAL = 0x2,
    ACIM = 0x3
}

[System.FlagsAttribute]
public enum ODriveError
{
    NONE = 0x0,
    INITIALIZING = 0x1,
    SYSTEM_LEVEL = 0x2,
    TIMING_ERROR = 0x4,
    MISSING_ESTIMATE = 0x8,
    BAD_CONFIG = 0x10,
    DRV_FAULT = 0x20,
    DC_BUS_OVER_VOLTAGE = 0x100,
    DC_BUS_UNDER_VOLTAGE = 0x200,
    DC_BUS_OVER_CURRENT = 0x400,
    DC_BUS_OVER_REGEN_CURRENT = 0x800,
    CURRENT_LIMIT_VIOLATION = 0x1000,
    MOTOR_OVER_TEMP = 0x2000,
    INVERTER_OVER_TEMP = 0x4000,
    VELOCITY_LIMIT_VIOLATION = 0x8000,
    POSITION_LIMIT_VIOLATION = 0x10000,
    WATCHDOG_TIMER_EXPIRED = 0x1000000,
    ESTOP_REQUESTED = 0x2000000,
    SPINOUT_DETECTED = 0x4000000,
    OTHER_DEVICE_FAILED = 0x8000000
}

public enum ProcedureResult
{
    SUCCESS = 0x0,
    BUSY = 0x1,
    CANCELLED = 0x2,
    DISARMED = 0x3,
    NO_RESPONSE = 0x4,
    POLE_PAIR_CPR_MISMATCH = 0x5,
    PHASE_RESISTANCE_OUT_OF_RANGE = 0x6,
    PHASE_INDUCTANCE_OUT_OF_RANGE = 0x7,
    UNBALANCED_PHASES = 0x8,
    INVALID_MOTOR_TYPE = 0x9,
    ILLEGAL_HALL_STATE = 0xA,
    TIMEOUT = 0xB,
    HOMING_WITHOUT_ENDSTOP = 0xC,
    INVALID_STATE = 0xD,
    NOT_CALIBRATED = 0xE
}

[System.FlagsAttribute]
public enum Protocol
{
    SIMPLE = 0x1
}

[System.FlagsAttribute]
public enum SensorlessEstimatorError
{
    NONE = 0x0,
    UNSTABLE_GAIN = 0x1,
    UNKNOWN_CURRENT_MEASUREMENT = 0x2
}

public enum SpiEncoderMode
{
    DISABLED = 0x0,
    RLS = 0x1,
    AMS = 0x2,
    CUI = 0x3,
    AEAT = 0x4,
    MA732 = 0x5
}

public enum StreamProtocolType
{
    FIBRE = 0x0,
    ASCII = 0x1,
    STDOUT = 0x2,
    ASCII_AND_STDOUT = 0x3,
    OTHER = 0x4
}

[System.FlagsAttribute]
public enum ThermistorCurrentLimiterError
{
    NONE = 0x0,
    OVER_TEMP = 0x1
}