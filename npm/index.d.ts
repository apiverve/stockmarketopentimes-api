declare module '@apiverve/stockmarketopentimes' {
  export interface stockmarketopentimesOptions {
    api_key: string;
    secure?: boolean;
  }

  /**
   * Describes fields the current plan does not unlock. Locked fields arrive as null
   * in `data`; `locked_fields` names them, using dot paths for nested fields.
   * Absent when the plan unlocks everything.
   */
  export interface PremiumInfo {
    message: string;
    upgrade_url: string;
    locked_fields: string[];
  }

  export interface stockmarketopentimesResponse {
    status: string;
    error: string | null;
    data: StockMarketOpenTimesData;
    code?: number;
    premium?: PremiumInfo;
  }


  interface StockMarketOpenTimesData {
      timezone:           null | string;
      exchange:           null | string;
      fullName:           null | string;
      isOpen:             boolean | null;
      openingTime:        Date | null;
      closingTime:        Date | null;
      status:             null | string;
      holidayName:        null;
      localTime:          Date | null;
      isHalfDay:          boolean | null;
      earlyCloseTime:     null;
      nextChange:         null | string;
      nextOpen:           Date | null;
      nextClose:          Date | null;
      minutesUntilChange: number | null;
      calendarVerified:   boolean | null;
  }

  export default class stockmarketopentimesWrapper {
    constructor(options: stockmarketopentimesOptions);

    execute(callback: (error: any, data: stockmarketopentimesResponse | null) => void): Promise<stockmarketopentimesResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: stockmarketopentimesResponse | null) => void): Promise<stockmarketopentimesResponse>;
    execute(query?: Record<string, any>): Promise<stockmarketopentimesResponse>;
  }
}
